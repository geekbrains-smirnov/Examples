int count = 0;
int distance = 1000;
int first_fr_speed = 1;
int second_fr_speed = 2;
int dog_speed = 5;
int friend = 2;
int time = 0;

while(distance > 10)
{
    if (friend != 1)
    { time = distance / (second_fr_speed + dog_speed);
    friend = 1;
    }
    
    else
    {
        time = distance / (first_fr_speed + dog_speed);
        friend = 2;
    }
    distance = distance - (first_fr_speed + second_fr_speed) * time;
    count++;
}

Console.WriteLine("Собака пробежит: ");
Console.WriteLine(count);
