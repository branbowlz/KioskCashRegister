using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Kiosk_Project
{


    class Program
    {
        //create gloal dictionary
        static Dictionary<string, string> moneybuttons = new Dictionary<string, string>();

        struct Kiosk
        {
            //establishing the public structure for the bills
            public string billName;
            public decimal billValue;
            public int billAmount;
            public decimal billBalance;
        };

        static void Main(string[] args)
        {
            //Dictionary<string, string> moneybuttons = new Dictionary<string, string>();

            //giving dictionary keyvalue pairs
            moneybuttons.Add("h", "100");
            moneybuttons.Add("f", "50");
            moneybuttons.Add("t", "20");
            moneybuttons.Add("j", "10");
            moneybuttons.Add("l", "5");
            moneybuttons.Add("o", "1");
            moneybuttons.Add("q", "0.25");
            moneybuttons.Add("d", "0.10");
            moneybuttons.Add("n", "0.05");
            moneybuttons.Add("p", "0.01");





            //this is the total amount of bills and coins in the kiosk currently. This amount will fluctuate as things get bought
           /* decimal totkbills = kioskbill1.billAmount + kioskbill2.billAmount + kioskbill3.billAmount + kioskbill4.billAmount + kioskbill5.billAmount +
                kioskbill6.billAmount + kioskbill7.billAmount + kioskbill8.billAmount + kioskbill9.billAmount + kioskbill10.billAmount;

            //this is the current amount of money in the kiosk. This amount should always be going up.
            decimal totkbalance = kioskbill1.billBalance + kioskbill2.billBalance + kioskbill3.billBalance + kioskbill4.billBalance + kioskbill5.billBalance
                + kioskbill6.billBalance + kioskbill7.billBalance + kioskbill8.billBalance + kioskbill9.billBalance + kioskbill10.billBalance;*/
            //put above in admin function. use kioskvalues from cash accepting function


            Console.WriteLine("Hello and Welcome to the No Homo-Sapien Services! Please Press any key to continue!");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No Homo-Sapien Services");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("This is a kiosk that is designed to help you pay for your items without the");
            Console.WriteLine("need for human interaction!");
            Console.WriteLine("Please enter the cost of your items below!");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            decimal itemprice = 0;
            decimal totitemprice = 0;
            string confirm = "";
            do
            {

                Console.WriteLine("Please Enter the cost of your item.");
                itemprice = itemprice + decimal.Parse(Console.ReadLine());
                Console.WriteLine("Do you have any more items that you would like to buy? If yes, please press y if no, please press n");
                confirm = Console.ReadLine().ToLower();

            } while (confirm == "y");

            totitemprice = itemprice;
            Console.WriteLine("Your total is: {0:C}", totitemprice);
            Console.WriteLine("We accept both cash and card. Press 1 to pay with cash or press 2 to pay with card.");
            string paymentChoice = Console.ReadLine();
            if (paymentChoice == "1")
            {
                decimal userchangeback = inputPayment(totitemprice);
                Console.WriteLine(userchangeback);
            }
            else if (paymentChoice == "2")
            {
                cardOption(totitemprice);
            }
            decimal userpayment1 = 0;
            decimal changeback = userpayment1 - totitemprice;
            //decimal userchangeback = userpayment1 - totitemprice;
            //decimal cardpayment = 0;
            //string cardconfirm = "";

            //contition for entering in other items using an if statement to loop through until they are done

            }//end main
            static void test()
            {
                Kiosk kioskbill1;
                kioskbill1.billName = "$100";
                Console.WriteLine(kioskbill1.billName);
            }
        static decimal inputPayment(decimal totitemprice)
            {
                Kiosk kioskbill1;
                Kiosk kioskbill2;
                Kiosk kioskbill3;
                Kiosk kioskbill4;
                Kiosk kioskbill5;
                Kiosk kioskbill6;
                Kiosk kioskbill7;
                Kiosk kioskbill8;
                Kiosk kioskbill9;
                Kiosk kioskbill10;

                kioskbill1.billName = "100 Dollars";
                kioskbill1.billValue = 100m;
                kioskbill1.billAmount = 0;
                kioskbill1.billBalance = kioskbill1.billValue * kioskbill1.billAmount;

                kioskbill2.billName = "50 Dollars";
                kioskbill2.billValue = 50m;
                kioskbill2.billAmount = 0;
                kioskbill2.billBalance = kioskbill2.billValue * kioskbill2.billAmount;

                kioskbill3.billName = "20 Dollars";
                kioskbill3.billValue = 20m;
                kioskbill3.billAmount = 20;
                kioskbill3.billBalance = kioskbill3.billValue * kioskbill3.billAmount;

                kioskbill4.billName = "10 Dollars";
                kioskbill4.billValue = 10m;
                kioskbill4.billAmount = 30;
                kioskbill4.billBalance = kioskbill4.billValue * kioskbill4.billAmount;

                kioskbill5.billName = "5 Dollars";
                kioskbill5.billValue = 5m;
                kioskbill5.billAmount = 40;
                kioskbill5.billBalance = kioskbill5.billValue * kioskbill5.billAmount;

                kioskbill6.billName = " 1 Dollar";
                kioskbill6.billValue = 1m;
                kioskbill6.billAmount = 100;
                kioskbill6.billBalance = kioskbill6.billValue * kioskbill6.billAmount;

                kioskbill7.billName = "Quarter";
                kioskbill7.billValue = 0.25m;
                kioskbill7.billAmount = 26;
                kioskbill7.billBalance = kioskbill7.billValue * kioskbill7.billAmount;

                kioskbill8.billName = "Dime";
                kioskbill8.billValue = 0.10m;
                kioskbill8.billAmount = 55;
                kioskbill8.billBalance = kioskbill8.billValue * kioskbill8.billAmount;

                kioskbill9.billName = "Nickel";
                kioskbill9.billValue = 0.05m;
                kioskbill9.billAmount = 60;
                kioskbill9.billBalance = kioskbill9.billValue * kioskbill9.billAmount;

                kioskbill10.billName = "Penny";
                kioskbill10.billValue = 0.01m;
                kioskbill10.billAmount = 250;
                kioskbill10.billBalance = kioskbill10.billValue * kioskbill10.billAmount;

                bool paymore = true;

                decimal userChangeback = 0.00m;
                string userpayment;

                while (paymore)
                {
                    Console.WriteLine("Please enter your payment one bill at a time. Please press the following for the bill amounts.");
                    Console.WriteLine("h-$100 f-$50 t-$20 j-$10 l-$5 o-$1 q-quarters d-dimes n-nickels p-pennies");
                    Console.WriteLine("Once you have paid everything, you will be given change back if necessary. ");
                    userpayment = Console.ReadLine();
                    decimal userpayment1 = Convert.ToDecimal(moneybuttons[userpayment]);
                    if (totitemprice > 0)
                    {

                        totitemprice -= userpayment1;
                        //userpayment1 -= totitemprice;
                        if (userpayment1 == kioskbill1.billValue)
                        {
                            kioskbill1.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill2.billValue)
                        {
                            kioskbill2.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill3.billValue)
                        {
                            kioskbill3.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill4.billValue)
                        {
                            kioskbill4.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill5.billValue)
                        {
                            kioskbill5.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill6.billValue)
                        {
                            kioskbill6.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill7.billValue)
                        {
                            kioskbill7.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill8.billValue)
                        {
                            kioskbill8.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill9.billValue)
                        {
                            kioskbill9.billAmount += 1;
                        }
                        else if (userpayment1 == kioskbill10.billValue)
                        {
                            kioskbill10.billAmount += 1;
                        }
                        userChangeback = userpayment1 - totitemprice;
                        if (totitemprice > 0)
                        {
                            Console.WriteLine("Your price owed is now ${0}", totitemprice);
                        }

                        if (totitemprice < 0)
                        {
                            Console.WriteLine("Your change back will be ${0}.", userChangeback);
                        }

                        else
                        {
                            paymore = false;
                            Console.WriteLine("Payment has been processed. Thank you for shopping with us!");
                            //Console.WriteLine(changeback);
                        }
                        //accept payment bill by bill
                        //decrease customer balance
                        //increase specfic bill slot in kiosk
                        //calculate userchangeback and assign
                    }
                }
                return userChangeback;

            }

 
        static void cardOption(decimal totitemprice)
        {
            //we neeed a code that will detect what will happen once the user has notified the kiosk that they are using a card
            //since there are many types of different cards, we will need to have some way of determining what card they are using
            //we will also need to make sure that whenever they use thier card, the cost of the item (totitemprice) equals out to 0
            //we will ask the user if they want change and if they do, we subtract the dollar bills from the total HOWEVER, we will keep the kiosk
            //updated so that it still has the proper amount of bills
            //accepted cards are visa, mastercard, discover and americanexpress
            //card validation of the type would be its own function
            //need to have partial payment as well. Some card some cash or vice versa.
            //visa starts with 4, mastercard starts with 5, discover starts with 6 and amex starts with 3
            Console.WriteLine("You have selected card validation");

            //inform what cards we accept when paying
            Console.WriteLine("We accept Visa, Mastercard, Discover and American Express");

            //have them enter in thier card number
            Console.WriteLine("Please enter in your card number");
            string cardnumber = Console.ReadLine();

            //sending card number to card validation function. Saving result as cardtype
            string cardtype = cardValidation(cardnumber);

            //Asking user if they want cash back but only if the card is a valid  card
            string cardConfirm = "";
            if (cardtype != "Invalid Card")
            {
                Console.WriteLine("Would you like cash back? Please type 'y' or 'n'");
                cardConfirm = Console.ReadLine().ToLower();
            }else if (cardtype == "Invalid Card")
            {
                Console.WriteLine(); 
            }
            if (cardConfirm == "y")
            {
                Console.WriteLine("How much would you like back? Please select from the following: ");
                Console.WriteLine("$5, $10, $20, $40");
                int cardChange = int.Parse(Console.ReadLine());
                if ( cardChange !=5 || cardChange !=10 || cardChange != 20 || cardChange !=40)
                {
                    Console.WriteLine("Invalid Choice, Please choose between $5, $10, $20 or $40");
                    cardChange = int.Parse(Console.ReadLine());
                }else
                {
                    Console.WriteLine("Your total, with change back included is ", totitemprice+cardChange);
                }
                
            }else if (cardConfirm == "n")
            {
                Console.WriteLine("Would you like to pay in full? Please press 'y' or 'n' ");
                string fullPpay = Console.ReadLine();
            }

            string[] answer = MoneyRequest(cardnumber, totitemprice);
            //Console.WriteLine(answer[0], answer[1]);
            //cofirming how much the user wants to pay out of the total
            //user input here
            //userpayment = double.Parse(Console.ReadLine());
            //totitemprice = totitemprice - userpayment;
            //We will need an if statement here. The if statement will determine if they have paid full price or partial payment
            //if they have done partial payment then it will ask them if they want to pay with card again or with cash and send them to the respective code
            //something along the lines of if totitemprice !0


        }

        static string cardValidation(string cardnumber)
            {


            //validating cardype and referencing it for when we do our if statements
            string cardtype = "";
            //cardnumber will be entered via the question above. Card number will determine what card they are using.
            //string cardnumber = Console.ReadLine();

            //if statements begin to validate the cardtype via the card number and the length
            if (cardnumber.StartsWith("4") && cardnumber.Length == 16)
            {
                cardtype = "Visa";
                return "Visa";

            }
            else if (cardnumber.StartsWith("5") && cardnumber.Length == 16)
            {
                cardtype = "Mastercard";
                return "Mastercard";
            }
            else if (cardnumber.StartsWith("6") && cardnumber.Length == 16)
            {
                cardtype = "Discover";
                return "Discover";
            }
            else if (cardnumber.StartsWith("3") && cardnumber.Length == 15)
            {
                cardtype = "American Express";
                Console.WriteLine(cardtype);
                return "American Express";

            }
            else
            {
                return "Invalid Card";
            }
        }

        static void changeBack(decimal userchangeback)
            {
                Kiosk kioskbill1;
                Kiosk kioskbill2;
                Kiosk kioskbill3;
                Kiosk kioskbill4;
                Kiosk kioskbill5;
                Kiosk kioskbill6;
                Kiosk kioskbill7;
                Kiosk kioskbill8;
                Kiosk kioskbill9;
                Kiosk kioskbill10;

                kioskbill1.billName = "100 Dollars";
                kioskbill1.billValue = 100m;
                kioskbill1.billAmount = 0;
                kioskbill1.billBalance = kioskbill1.billValue * kioskbill1.billAmount;

                kioskbill2.billName = "50 Dollars";
                kioskbill2.billValue = 50m;
                kioskbill2.billAmount = 0;
                kioskbill2.billBalance = kioskbill2.billValue * kioskbill2.billAmount;

                kioskbill3.billName = "20 Dollars";
                kioskbill3.billValue = 20m;
                kioskbill3.billAmount = 20;
                kioskbill3.billBalance = kioskbill3.billValue * kioskbill3.billAmount;

                kioskbill4.billName = "10 Dollars";
                kioskbill4.billValue = 10m;
                kioskbill4.billAmount = 30;
                kioskbill4.billBalance = kioskbill4.billValue * kioskbill4.billAmount;

                kioskbill5.billName = "5 Dollars";
                kioskbill5.billValue = 5m;
                kioskbill5.billAmount = 40;
                kioskbill5.billBalance = kioskbill5.billValue * kioskbill5.billAmount;

                kioskbill6.billName = " 1 Dollar";
                kioskbill6.billValue = 1m;
                kioskbill6.billAmount = 100;
                kioskbill6.billBalance = kioskbill6.billValue * kioskbill6.billAmount;

                kioskbill7.billName = "Quarter";
                kioskbill7.billValue = 0.25m;
                kioskbill7.billAmount = 26;
                kioskbill7.billBalance = kioskbill7.billValue * kioskbill7.billAmount;

                kioskbill8.billName = "Dime";
                kioskbill8.billValue = 0.10m;
                kioskbill8.billAmount = 55;
                kioskbill8.billBalance = kioskbill8.billValue * kioskbill8.billAmount;

                kioskbill9.billName = "Nickel";
                kioskbill9.billValue = 0.05m;
                kioskbill9.billAmount = 60;
                kioskbill9.billBalance = kioskbill9.billValue * kioskbill9.billAmount;

                kioskbill10.billName = "Penny";
                kioskbill10.billValue = 0.01m;
                kioskbill10.billAmount = 250;
                kioskbill10.billBalance = kioskbill10.billValue * kioskbill10.billAmount;

                while (Math.Abs(userchangeback) > 0.00m)
                {
                    //this is a greedy algorithm that checks for the highest possible denomination that can be returned first
                    //once it is found that amount is subtracted from the changeDue, a bill of the greatest denomination found is taken
                    //out of the till then a record of the bill is added to the cash_returned queue
                    //the order is $100, $50, $20, $10, $5, $2, $1, 50¢, 25¢, 10¢, 5¢, 1¢
                    //once the algorithm runs all the way through the change should be exactly $0.00 and the program
                    //will return true for correctly broken change

                    //since this is a till, the till is checked as well as the change due so no money is subtracted from the till that is not there
                    //therefore there is an extra if else case at the end accounting for the inability to make change
                    //if the kiosk does not have correct change the function will return false and the function breaks

                    //$100
                    if (Math.Abs(userchangeback) <= 100m && kioskbill1.billAmount > 0)
                    {
                        kioskbill1.billAmount--;
                        userchangeback -= 100m;
                        //$50
                        Console.WriteLine("$100 dollars dispensed");
                    }
                    else if (Math.Abs(userchangeback) <= 50m && kioskbill2.billAmount > 0)
                    {
                        kioskbill2.billAmount--;
                        userchangeback -= 50m;
                        Console.WriteLine("$50 dollars dispensed");
                        //$20
                    }
                    else if (Math.Abs(userchangeback) <= 20m && kioskbill3.billAmount > 0)
                    {
                        kioskbill3.billAmount--;
                        userchangeback -= 20m;
                        Console.WriteLine("$20 dollars dispensed");
                        //$10
                    }
                    else if (Math.Abs(userchangeback) <= 10m && kioskbill4.billAmount > 0)
                    {
                        kioskbill4.billAmount--;
                        userchangeback -= 10m;
                        Console.WriteLine("$10 Dollars dispensed");
                        //$5
                    }
                    else if (Math.Abs(userchangeback) <= 5m && kioskbill5.billAmount > 0)
                    {
                        kioskbill5.billAmount--;
                        userchangeback -= 5m;
                        Console.WriteLine("$5 dollars dispensed");
                        //$2
                    }
                    /*else if ((totitemprice >= 2.00m && till["1.00"] < 10) && till["2.00"] > 0)
                    {
                        till["2.00"]--;
                        cash_returned.Enqueue("2.00");
                        changeDue -= 2.00m;
                        //$1
                    }*/
                    else if (Math.Abs(userchangeback) <= 1m && kioskbill6.billAmount > 0)
                    {
                        kioskbill6.billAmount--;
                        userchangeback -= 1.00m;
                        Console.WriteLine("$1 dollar dispensed");

                        //50¢
                    }
                    /*else if ((totitemprice >= 0.50m && till["0.25"] < 6) && till["0.50"] > 0)
                    {
                        till["0.50"]--;
                        cash_returned.Enqueue("0.50");
                        changeDue -= 0.50m;
                        //25¢
                    }*/
                    else if (Math.Abs(userchangeback) <= 0.25m && kioskbill7.billAmount > 0)
                    {
                        kioskbill7.billAmount--;
                        userchangeback -= 0.25m;
                        Console.WriteLine("25¢ dispensed");
                        //10¢
                    }
                    else if (Math.Abs(userchangeback) <= 0.10m && kioskbill8.billAmount > 0)
                    {
                        kioskbill8.billAmount--;
                        userchangeback -= 0.10m;
                        Console.WriteLine("10¢ dispensed");
                        //5¢
                    }
                    else if (Math.Abs(userchangeback) <= 0.05m && kioskbill9.billAmount > 0)
                    {
                        kioskbill9.billAmount--;
                        userchangeback -= 0.05m;
                        Console.WriteLine("5¢ dispensed");
                        //1¢
                    }
                    else if (Math.Abs(userchangeback) <= 0.01m && kioskbill10.billAmount > 0)
                    {
                        kioskbill10.billAmount--;
                        userchangeback -= 0.01m;
                        Console.WriteLine("1¢ dispensed");
                        //kiosk does not have enough change to return
                    }
                    else if (Math.Abs(userchangeback) <= 0.01m)
                    {
                        //return false;
                        Console.WriteLine("Not enough change available. Please try another payment");
                        break;
                    }
                }
            }

        static string[] MoneyRequest(string account_number, decimal amount)
        {
            Random rnd = new Random();
            //50% CHANCE TRANSACTION PASSES OR FAILS
            bool pass = rnd.Next(100) < 50;
            //50% CHANCE THAT A FAILED TRANSACTION IS DECLINED
            bool declined = rnd.Next(100) < 50;

            if (pass)
            {
                Console.WriteLine("Card Accepted");
                return new string[] { account_number, amount.ToString() };

            }
            else
            {
                if (!declined)
                {
                    Console.WriteLine("Card was not accepted. Please try again");
                    return new string[] { account_number, (amount / rnd.Next(2, 6)).ToString() };
                }
                else
                {
                    return new string[] { account_number, "Card declined, please try your payment again" };
                }//end if
            }//end if

        }//end if
    }
    }



