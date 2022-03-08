//Uc5
using System;

    int empHr = 0;
    int empwage = 0;
    int totalEmpwage = 0;
    int IS_PART_TIME = 1;
    int IS_FULL_TIME = 2;
    int EMP_HR_PER_RATE = 20;
    int NUM_OF_WORKING_DAYS = 20;
for (int day=0; day < NUM_OF_WORKING_DAYS; day++)
    {
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        switch (empCheck)
        {
            case 1:
     
                empHr = 4;
                break;
            case 2:
                empHr = 8;
                break;
            default:
                empHr = 0;
                break;
        }
    empwage = (EMP_HR_PER_RATE + empHr);
    totalEmpwage += empwage;
    Console.WriteLine("daily employee wage" + empwage);
    Console.WriteLine("total Emp wage" + totalEmpwage);


}
    
