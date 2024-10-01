using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job("Microsoft", "Software engineer",2019, 2022);
        Job job2= new Job("Apple", "Manager",2022, 2023);

        Resume myResume= new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }}