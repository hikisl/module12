using System;
using System.Threading;

namespace module12
{
    public class Advertisement
    {
		static void ShowAds()
		{
			Console.WriteLine("�������� ��� ����� ���� � ����������� ������ free.games.for.a.fool.com");
			// ��������� �� 1 �
			Thread.Sleep(1000);

			Console.WriteLine("������ �������� �� ������� � �������� ������ ����� � ������.");
			// ��������� �� 2 �
			Thread.Sleep(2000);

			Console.WriteLine("�������� �������-�������� �� ��� ������, ����� �� ������ �������.");
			// ��������� �� 3 �
			Thread.Sleep(3000);
		}
	}
}