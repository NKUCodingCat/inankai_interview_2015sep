/*

 * File: Print.java

 * ----------------------------

 * you should import first,then,it works.

 * author Puorus<136483159@qq.com>
 
 *-----------------------------
 
 * I hope this file works.
 
 * If you want to run this Program, Maybe it's useful for you.
 
      * http://alorry.blog.163.com/blog/static/6472570820117188271052/
	  
	  * http://web.stanford.edu/class/cs106a/
	  
 * Good luck :)  ---NKUCodingCat<admin@NKUCodingCat.com>

 */




import stanford.karel.*;

public class Print extends SuperKarel {

	public void run() {

		/* You fill this in */

		move();turnLeft();wowSexBepper();thisWayNotWrongSir();putFoolBepper();thisWayNotWrongSir();put_1_1_1bepper();thisWayNotWrongSir();putFoolBepper();

	}


	public void thisWayNotWrongSir(){

		turnLeft();turnLeft();turnLeft();

	}

	private void wowSexBepper(){

		for(int i=0;i<6;i++){

			putBeeper();move();

		}

	}

	private void putFoolBepper(){

		for(int i=0;i<4;i++){

			putBeeper();move();

		}

	}

	private void put_1_1_1bepper(){

		for(int i=0;i<3;i++){

			putBeeper();move();

		}

	}

}
