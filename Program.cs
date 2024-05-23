// See https://aka.ms/new-console-template for more information
using System;



int currentAssignments = 5;

String[] student=new string[4]{"Sarij","Adam","Emma","Logan"};

int[] Sarij = new int[5];
Sarij[0] = 90;
Sarij[1] = 86;
Sarij[2] = 87;
Sarij[3] = 98;
Sarij[4] = 100;

int[] Adam =new int[5];
Adam[0] = 92;
Adam[1] = 89;
Adam[2] = 81;
Adam[3] = 96;
Adam[4] = 90;

int[] emma =new int [5];
emma[0] = 90;
emma[1] = 85;
emma[2] = 87;
emma[3] = 98;
emma[4] = 68;


int[] logan=new int [5];
 logan[0] = 90;
 logan[1] = 95;
 logan[2] = 87;
 logan[3] = 88;
 logan[4] = 96;

Console.WriteLine("Student\t\tGrade\n");


var grade ="string";

foreach (var name in student)
{
    
int[] score=new int[10];
int scoreSum=0;

if ($"{name}"=="Sarij")
{
    score=Sarij;
}
else if ($"{name}"=="Adam")
{
    score=Adam;
}
else if($"{name}"=="Emma"){
    score=emma;
}
else if($"{name}"== "Logan") {
    score=logan;
}


foreach (var item in score)
{
    scoreSum +=item;
}


decimal average;




average = (decimal)scoreSum/ currentAssignments;


if (average >= 97)
        grade = "A+";

    else if (average >= 93)
        grade = "A";

    else if (average >= 90)
        grade = "A-";

    else if (average >= 87)
        grade = "B+";

    else if (average >= 83)
        grade = "B";

    else if (average >= 80)
        grade = "B-";

    else if (average >= 77)
        grade = "C+";

    else if (average >= 73)
        grade = "C";

    else if (average >= 70)
        grade = "C-";

    else if (average >= 67)
        grade = "D+";

    else if (average >= 63)
        grade = "D";

    else if (average >= 60)
        grade = "D-";

    else
        grade = "F";

    


Console.WriteLine($"{name}:\t\t{average} \t{grade}");

}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

