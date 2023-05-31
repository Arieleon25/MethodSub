# MethodSub

The MethodSub project is a console application that demonstrates the usage of optional parameters in a method in C#. It includes a class with a method that takes two integers as parameters, with one of them being optional. The method performs a math operation and returns an integer result. The Main() method of the console app instantiates the class and asks the user to input two numbers. It then calls the method, passing in the user-entered numbers, and displays the result on the screen.

# Project Description

The MethodSub project consists of a single file named Program.cs.

Program.cs

This file contains the Main() method, which serves as the entry point of the application. It interacts with the user, instantiates an object of the class MathOperations, and calls the method with one or two numbers as parameters, displaying the returned integer result.

The MathOperations class contains the following method:

PerformMathOperation(int num1, int num2 = 0)

Takes two integer parameters, num1 and num2, with num2 being optional and assigned a default value of 0.

Performs a math operation on the two numbers.

Returns the result of the math operation as an integer.

# Instructions

Start the console application.

The program will instantiate an object of the MathOperations class.

The program will prompt the user to enter the first number.

Enter an integer value for the first number and press Enter.

The program will prompt the user to enter the second number.

Enter another integer value for the second number, or simply press Enter without entering anything to use the default value of 0.

The program will call the PerformMathOperation() method, passing in the entered numbers.

The returned integer result from the method will be displayed on the screen.

Observe the result of the math operation performed on the entered numbers.

You can try various combinations of numbers, including providing only the first number and leaving the second number empty, to see how the method handles optional parameters.

The program will terminate, and you can rerun it to perform calculations with different numbers.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to optional parameters and console applications in C#:

Defining and implementing a method with optional parameters

Passing one or two numbers as method parameters

Performing a math operation on the given numbers

Returning an integer result from a method

Instantiating an object of a class

Interacting with the user through console input

Displaying integer results to the screen


Handling optional parameters when calling a method
