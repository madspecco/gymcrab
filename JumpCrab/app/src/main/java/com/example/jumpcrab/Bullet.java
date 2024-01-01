package com.example.jumpcrab;

import android.graphics.Bitmap;
import java.util.ArrayList;

public class Bullet extends Entity {

    /**Default constructor; creates a Bullet object with default values for attributes (0 or null)*/
    public Bullet() {
        super();
    }

    /**
     * Creates a Bullet object with the attributes specified by the parameters
     * @param bitmap Bitmap storing image of Bullet
     * @param xPos current x position of Bullet
     * @param yPos current y position of Bullet
     * @param xSpeed current x speed of Bullet
     * @param ySpeed current y speed of Bullet
     */
    public Bullet(Bitmap bitmap, float xPos, float yPos, float xSpeed, float ySpeed){
        super(bitmap, xPos, yPos, xSpeed, ySpeed);
    }


}
