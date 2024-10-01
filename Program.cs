// Use if and else statements instead of two separate if statements

/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
//instead of [ if (total < 15) ] ,well use 'else'
else 
{
    Console.WriteLine("Sorry, you lose.");
}*/

/**********************************************/
//Modify the code to remove the stacking bonus for doubles and triples using nesting

//Nesting allows you to place code blocks inside of code blocks. In this case, you'll nest an if and else combination (the check for doubles) inside of another if statement (the check for triples) to prevent both bonuses from being awarded.

/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){

   if ((roll1 == roll2) && (roll2 == roll3)) {
      Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
   }
   else{
     Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
   }
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}*/


/*******************************************/

//Use if, else, and else if statements to give a prize instead of a win-lose message
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    if((roll1 == roll2) && (roll2 == roll3)) {

        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else{
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total +=2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}
if(total >= 16){
   
    Console.WriteLine("You win a new car!");
}
else if( total >= 10){
        Console.WriteLine("You win a new laptop!");
}
else if( total == 7){
    Console.WriteLine("You win a trip for two!");
}
else{
     Console.WriteLine("You win a kitten!");
}
