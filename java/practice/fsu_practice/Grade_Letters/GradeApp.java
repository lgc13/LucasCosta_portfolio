import java.util.Scanner;
class GradeAp
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);
		float num = 0;
		int count = 0;
		float sum = 0;

		while(num >= 0 && num <= 100 )
		{
			System.out.print("Enter Score: ");
			num=sc.nextFloat();
			if(num >= 0 && num <= 100 )
			{
				count++;
				sum += num;
			}
			else if(num!=-1)
			{
				System.out.println("Invalid entry, not counted\n");
				num = 0;
			}

		}
		System.out.printf("Count: %d \nTotal: %.2f \nAverage: %.2f",count, sum, sum/count);

	}
}
