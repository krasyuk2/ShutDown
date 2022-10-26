int countDown = 0;
KD();
void KD() {
    Random random = new Random();
    int randomNumber = random.Next(600000, 1200000);
    Console.WriteLine(randomNumber);
    Thread.Sleep(randomNumber);
    ShutDown();
    countDown++;
    if (countDown == 3)  return;
    KD();
}

void ShutDown(string cmdText = "/K shutdown /s /t 0 /m \\192.168.0.20") => System.Diagnostics.Process.Start("CMD.exe",cmdText);
