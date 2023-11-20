// sum of points
int sumPoints = 0;

// number of points
int numPoints = 5; 

int index = 0;

while(index < numPoints)
{
    int point;

    Console.Write("Enter {0} point: ", index + 1);

    while (true)
    {
        bool valid = int.TryParse(Console.ReadLine(), out point);

        if (valid)
            break;

        Console.Write("Again enter {0} point: ", index + 1);
    }

    sumPoints += point;
    index++;
}

double avg = sumPoints / numPoints;

if (avg >= 50)
{
    Console.WriteLine("Student's assumptions for the exam -> {0} > 50", avg);
}
else
{
    Console.WriteLine("Student not admitted to the exam -> {0} < 50", avg);
}