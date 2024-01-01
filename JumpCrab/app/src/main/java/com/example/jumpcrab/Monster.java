package com.example.jumpcrab;


import android.graphics.Bitmap;

import java.util.Random;

public class Monster extends Entity {
    static float minDistanceBetweenPlayerAndMonster = 0;
    /**Chance to spawn monster; higher numbers mean lower chance to spawn*/
    private final static int chanceToSpawnMonster = 5;
    private static Random randomGen = new Random();

    boolean isAMovingMonster;

    /**
     * Default constructor; creates a Monster object with default values for
     * attributes (0, null or false)
     */
    public Monster(){
        super();
        isAMovingMonster = false;
    }

    /**
     * Create a Monster object with the attributes specified by the parameters
     * @param bitmap Bitmap storing image of monster
     * @param xPos current x position of monster
     * @param yPos current y position of monster
     * @param xSpeed current x speed of monster
     * @param ySpeed current y speed of monster
     * @param isAMovingMonster boolean storing whether the monster moves or not
     */
    public Monster(Bitmap bitmap, float xPos, float yPos, float xSpeed, float ySpeed,
                   boolean isAMovingMonster){
        super(bitmap, xPos, yPos, xSpeed, ySpeed);
        this.isAMovingMonster = isAMovingMonster;
        if(this.isAMovingMonster) {
            this.xSpeed = 50;
            this.ySpeed = 0;
        }
    }

}

