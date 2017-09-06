using System;
/*
Some classes will have a 'namespace'. If you are familiar with Java,
it would be the equivilant to 'package'

'namespace' is an organizational tool to specify groups of files
*/
class CSharpVol1
{
    static void Main(String[] args)
    {
        Console.WriteLine("Greetings");
    }
    /* //User Input
	The simplist way of taking input from the user is:
	Console.ReadLine(); //Individual String
	or 
	console.Read(); //Individual Character

    */

    /* //Enhanced for loop
	We have seen 'for' loops written as:
		for(int i = 0; i > 10; i++){
			(code)
		}

	When we want to use an array "in place" of the 'i' variable, we can use an Enhanced for loop (or 'for-each' loop)
	Enhanced for loops are written as such:
		
		int[] array = new int[] {0,1,2,3};

		foreach (int i in array){
			(code)
		}

    */

    /* //arrays
	int[,] array = new int[,] {0, 1, 2, 3, 4};
	
	array[0] would be 0
	array[1] would be 1
	array[2] would be 2

	int[, ,] multiArray = new int[,,] {{0,10,20},{5,15,25}};
	//Each comma allocates another dimension

	multiArray[0,0] would be 0
	multiArray[1,0] would be 5
	multiArray[0,1] would be 10

	//Arrays don't necessarily have to be int data types. Arrays are an organizational tool that groups variables into
	//a more accessible access point
	
    */

    /* //switch statement
        switch(variable){
            case x:
                (code);
                break;
            case y:
                (code);
                break;
            case z:
                (code);
                break;
            default:
                (code);
                break;
        }

    */

    /* //for loop
        for(int i = 0; i < 10; i++){
            Console.WriteLine("The current iteration is: " + i);
        }

    What the above code is doing is creating an int variable, comparing
    it to another variable (in this case a constant), running the code if
    the comparison returns true, then increment the int variable (in this
    case i) by 1

    Whenever you want to run something a specific amount of times, a for
    loop is definitely an option to use.
    */

    /* //while & do-while loops
        while(parameter){
            Console.WriteLine("This is a while loop");
        }
    */

    /* //if/else statement
        if(parameter_a){

        }else if (parameter_b){

        }else{

        }

    An if statement is an easy way to implement control flow into a program.
    The code written within an if statement has to return either true or false.
    Using the logical operators below, you can compare different variables to each other
	to return a boolean value within the parameters.
    */
    
    /* //Logical Operators
	In C# there are three logical operators:
		- && which is equivilant to 'and'
		- || which is equivilant to 'or'
		- !  which is equivilant to 'not'
		- == which is equivilant to 'equal to'

	Here are some combinations using straight true/false values:
		true and true 		equals true
		true and false 		equals false
		false and false 	equals false
		true or true 		equals true
		true or false 		equals true
		false or false 		equals true
		!true 			equals false
		!false 			equals true

	&& requires that both arguments return true for the whole parameter to return true
	|| requires that only one argument needs to return true for the whole parameter to return true
	!  returns the opposite boolean value
	() can be used to specify what arguments are being compared and in what order
    */

    /* //Declaring/Initializing Variables
    (Data type) (variable name) = (value);

    int x           = 10;
    double a        = 3.14;
    String name     = "Antonio";
    boolean isOpen  = false;

    To declare a variable is to create the variable without giving it a value.
    Once a variable recieves a value, then that variable is considered initialized.
    */

    /* //Intro to Data Types
    There are several variable data types, but the primary ones are:
    -int        (A whole number)
    -double     (A number with a decimal place or extends out of integer boundaries)
    -String     (Written characters; name, phrase, etc.)
    -Char       (an individual character)
    -boolean    (a value of true or false)
    -Object     (we will get to Objects in a different section)

    Each of the numeric data types has their own boundaries:
    -byte       =   0 to 255
    -sbyte      =   -128 to 127
    -short      =   -32,768 to 32,767
    -ushort     =   0 to 65,535
    -int        =   -2,147,483,648 to 2,147,483,647
    -uint       =   0 to 4,294,967,295
    -long       =   
    -ulong      =   
    -float      =   
    -double     =   
    -decimal    =   
    
    Knowing how much memory is being alloted for what variables
        doesn't necessarily take a toll within small projects,
        but on a massive scale, allotting more memory to hold a
        variable that doesn't use it all will eventually depreciate
        the efficiency of the program
    */


    /* //Hello World && Basic Print statement
    //The first example for any beginning programmer
        Console.WriteLine("Hello World");

    Console.WriteLine(); is how to print a 
    statement to the console/terminal
    */
}
