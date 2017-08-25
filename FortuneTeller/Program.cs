﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Morpheus, the Fortune Teller! What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("And what is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Thank you. How old are you?");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Using a digit, please enter your birth month! For example, Jan=01");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV colors? For help, type help");
            string colorAnswer = Console.ReadLine().ToLower();
            if (colorAnswer == "help")
            {
                Console.WriteLine("ROYGBIV colors are \n R is for Red\n O is for Orange\n Y is for Yellow\n G is for Green\n B is for Blue\n I is for Indigo\n V is for Violet. \nFrom the list above, tell me your favorite color.");
                colorAnswer = Console.ReadLine().ToLower();
            }
            int retiringAge = 0;
            if (userAge % 2 == 0)
            {
                retiringAge = 7;
            }
            else
            {
                retiringAge = 15;
            }
            string vacationHome = " ";
            if (siblings ==0)
            {
                vacationHome = "Cleveland";
            }
            else if (siblings ==1)
            {
                vacationHome = "Japan";
            }
            else if (siblings ==2)
            {
                vacationHome = "Australia";
            }
            else if (siblings >=3)
            {
                vacationHome = "Brazil";
            }
            string modeOfTransportation = " ";
            if (colorAnswer == "red")
            {
                modeOfTransportation = "Red Mountain Bike"; 
            }
            else if (colorAnswer == "orange")
            {
                modeOfTransportation = "Orange Train";
            }
            else if (colorAnswer == "yellow")
            {
                modeOfTransportation = "Yellow Ice Cream Truck";
            }
            else if (colorAnswer == "green")
            {
                modeOfTransportation = "Horse and Carriage";
            }
            else if (colorAnswer == "blue")
            {
                modeOfTransportation = "Airplane";
            }
            else if (colorAnswer == "indigo")
            {
                modeOfTransportation = "Hoverboard";
            }
            else if (colorAnswer == "violet")
            {
                modeOfTransportation = "Rocketship";
            }
            int moneyInBank = 0;
            if (birthMonth >=1 && birthMonth<=4)
            {
                moneyInBank = 5000;
            }
            else if (birthMonth >=4 && birthMonth<=8)
            {
                moneyInBank = 500000; 
            }
            else if (birthMonth >=8 && birthMonth<=13)
            {
                moneyInBank = 5000000;
            }
            Console.WriteLine(firstName + " " + lastName + " " + "will retire in"+ " " + retiringAge +" "+ "years with" +" " + "$" + moneyInBank + " " + "in the bank" + "," + " a vacation home \nin " + vacationHome + " and will cruise around in a " + modeOfTransportation + "!");


        

          

        }
    }
}
