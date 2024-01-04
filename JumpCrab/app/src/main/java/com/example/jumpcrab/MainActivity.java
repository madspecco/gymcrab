package com.example.jumpcrab;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.Typeface;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.InputStreamReader;

public class MainActivity extends Activity {

    private static final int MENU_RESUME = 1;
    private static final int MENU_START = 2;
    private static final int MENU_STOP = 3;

    private GameThread mGameThread;
    private GameView mGameView;
    private PlatformType platformType;

    private RelativeLayout gameLayout;
    private LinearLayout endGameLayout;

    private Typeface font;
    private int headingFontSize;
    private int bodyFontSize;
    private int colour;

    /**
     * Called when the activity is first created.
     */
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        requestWindowFeature(Window.FEATURE_NO_TITLE);

        getWindow().addFlags(WindowManager.LayoutParams.FLAG_KEEP_SCREEN_ON);

        setContentView(R.layout.main_activity);

        //get info from level select screen
        Bundle extras = getIntent().getExtras();
        if (extras != null) {
            platformType = PlatformType.valueOf(extras.getString("PlatformType"));
        }

        //Labels
        TextView text = (TextView) findViewById(R.id.gameStatusText);
        TextView score = (TextView) findViewById(R.id.score);

        //Style labels
        font = Typeface.createFromAsset(getAssets(), "Luna.ttf");
        headingFontSize = 25;
        bodyFontSize = 20;
        colour = Color.WHITE;
        styleFont(text, font, headingFontSize, colour);
        styleFont(score, font, headingFontSize, colour);

        mGameView = (GameView)findViewById(R.id.gamearea);
        mGameView.setStatusView(text);
        mGameView.setScoreView(score);
        mGameView.setOnGameEndListener(new GameEndListener() {
            @Override
            public void gameHasEnded() {
                endGame();
            }
        });

        this.startGame();
    }

    /**
     * Start the game and game thread
     */
    private void startGame() {
        //Set up level based on user choice
        Level level = new Level(platformType);


        //Set up a new game, we don't care about previous states
        mGameThread = new TheGame(mGameView, level);
        mGameView.setThread(mGameThread);
        mGameView.setLevel(level);
        mGameThread.setState(GameThread.STATE_READY);
        mGameView.startSensor((SensorManager)getSystemService(Context.SENSOR_SERVICE));
    }

    /**
     * Restart the game with the same settings (i.e. same level)
     */
    private void restartGame() {
        mGameThread.doStart();
    }

    /**
     * Trigger game end screen allowing user to send their score, start a new game
     * or return to level select menu.
     */
    private void endGame() {
        gameLayout = (RelativeLayout) findViewById(R.id.gameLayout);

        LayoutInflater inflater = LayoutInflater.from(getApplicationContext());
        endGameLayout = (LinearLayout) inflater.inflate(R.layout.game_end_view, gameLayout, false);

        gameLayout.addView(endGameLayout);

        //Labels
        final TextView gameOverText = (TextView) findViewById(R.id.gameOverText);

        //Buttons
        final Button startGameButton = (Button) findViewById(R.id.startGameButton);
        final Button backButton = (Button) findViewById(R.id.endGameBackButton);


        //Set style of text and buttons
        styleFont(gameOverText, font, headingFontSize, colour);
        styleFont(startGameButton, font, bodyFontSize, colour);
        styleFont(backButton, font, bodyFontSize, colour);

        //prevent buttons from becoming all uppercase in high API levels
        startGameButton.setTransformationMethod(null);
        backButton.setTransformationMethod(null);



        startGameButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //remove the endGameLayout from the game layout
                gameLayout.removeView(endGameLayout);
                //restart game
                restartGame();
            }
        });

        backButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
                //return to menu
                Intent showLevelSelectScreen = new Intent(getApplicationContext(), LevelSelectActivity.class);
                startActivity(showLevelSelectScreen);
            }
        });
    }


    /*
     * Activity state functions
     */

    @Override
    protected void onPause() {
        super.onPause();

        if(mGameThread.getMode() == GameThread.STATE_RUNNING) {
            mGameThread.setState(GameThread.STATE_PAUSE);
        }
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();

        mGameView.cleanup();
        mGameView.removeSensor((SensorManager)getSystemService(Context.SENSOR_SERVICE));
        mGameThread = null;
        mGameView = null;
    }

    /*
     * UI Functions
     */

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        super.onCreateOptionsMenu(menu);

        menu.add(0, MENU_START, 0, "Start");
        menu.add(0, MENU_STOP, 0, "Stop");
        menu.add(0, MENU_RESUME, 0, "Resume");

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case MENU_START:
                mGameThread.doStart();
                return true;
            case MENU_STOP:
                mGameThread.setState(GameThread.STATE_LOSE,  getText(R.string.message_stopped));
                return true;
            case MENU_RESUME:
                mGameThread.unpause();
                return true;
        }

        return false;
    }

    public void onNothingSelected(AdapterView<?> arg0) {
        // Do nothing if nothing is selected
    }

    /**
     * Style text according to parameters specified
     * @param textView the text to be styled
     * @param font the font to be applied to the text
     * @param fontSize the size the text will be set to
     * @param colour the colour to be applied to the text
     */
    private void styleFont(TextView textView, Typeface font, int fontSize, int colour) {
        textView.setTypeface(font);
        textView.setTextColor(colour);
        textView.setTextSize(fontSize);
    }
}

