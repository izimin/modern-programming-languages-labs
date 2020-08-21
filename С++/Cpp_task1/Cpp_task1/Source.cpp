#include <iostream>
#include <string>
#include "TreeAVL.h"
#include "Classes.h"
#include "typeinfo.h"

using namespace std;

node *as = NULL;

int ReadIntNum()
{
	int number;
	while (!(cin >> number) || (cin.peek() != '\n'))
	{
		cin.clear();
		while (cin.get() != '\n');
		cout << "\n***��� �� ����� �����!***\n������� ������ ->";
	}
	//cout << "-------------------------------------------------------------------------------------------------------------------------\n";
	return number;
}

double ReadDoubleNum()
{
	double number;
	while (!(cin >> number) || (cin.peek() != '\n'))
	{
		cin.clear();
		while (cin.get() != '\n');
		cout << "\n***��� �� ������������ �����!***\n������� ������ ->";
	}
	//cout << "-------------------------------------------------------------------------------------------------------------------------\n";
	return number;
}
void Find(node * as, int num, Kitchenware *&fElem)
{
	if (!as) return;
	if (num > as->key->inventoryNumber)
		Find(as->right, num, fElem);
	else if (num < as->key->inventoryNumber)
		Find(as->left, num, fElem);
	else if (num == as->key->inventoryNumber) fElem = as -> key;
}
void PrintElem()
{
	cout << "������� ����������� �����: ";
	Kitchenware* elem = NULL;
	Find(as, ReadIntNum(), elem);
	if (!elem)
	{
		cout << "������� �� ������ :(\n";
		return;
	}
	cout << PrintType(elem) << endl;
	elem->print(true);
	cout << "-------------------------------------------------------------------------------------------------------------------------\n";
}

int GetNum(int a)
{
	cout << "��� ����� -> ";
	int num = ReadIntNum();
	while (num > a || num < 1)
	{
		cout << "\n***������ ������ ���!***\n������� ������ -> ";
		num = ReadIntNum();
	}
	return num;
}
void PrintAllElem()
{
	cout << "����� ����� �������������? \n\t1 - ������ | 2 - �������� | 3 - �������������\n";
	switch (GetNum(3))
	{
	case 1: ShowKLR(as); break;
	case 2: ShowLRK(as); break;
	case 3: ShowLKR(as); break;
	default: break;
	}
}

void DeleteElem()
{
	cout << "������� ����������� �����: ";
	Kitchenware* elem = NULL;
	Find(as, ReadIntNum(), elem);
	if (!elem) {
		cout << "�������� ���!\n";
		system("pause");
		return;
	}
	as = remove(as, elem->inventoryNumber);

}

string GetColor()
{
	string color;
	cout << "������� ����: -> ";
	cin >> color;
	return color;
}

double GetGasConsumption()
{
	cout << "������� �������������� ����: -> ";
	return ReadDoubleNum();
}

double GetPower()
{
	cout << "������� ��������: -> ";
	return ReadDoubleNum();
}

double GetVolume()
{
	cout << "������� �����: -> ";
	return ReadDoubleNum();
}
int GetInventoryNumber()
{
	cout << "������� ����������� ����� -> ";
	return ReadIntNum();
}

bool GetIsPressureCooker()
{
	bool isPressureCooker = false;
	cout << "�������� �� �������� ����������? (y/_): ";
	char c;
	cin >> c;
	if (c == 'y')
		isPressureCooker = true;
	return isPressureCooker;
}
void Add()
{
	cout << "�������� �������:  1 - ����� | 2 - ������� ����� | 3 - ������������� ����� | 4 - �������� | 5 - �����������\n";
	int num  = GetNum(5);
	int inventoryNumber = GetInventoryNumber();
	Kitchenware* elem = NULL;
	Find(as, inventoryNumber, elem);
	if (elem)
	{
		cout << "������� � ���� ���������� ������� ��� ���� :(\n";
		system("pause");
		return;
	}

	switch (num)
	{
	case 1:
			as = insert(as, new Stove(GetColor(), inventoryNumber));
			break;
	case 2:  
			as = insert(as, new GasStove(GetGasConsumption(), GetColor(), inventoryNumber));
			break;
	case 3:
			as = insert(as, new ElectricStove(GetPower(), GetColor(), inventoryNumber));
			break;
	case 4: 
			as = insert(as, new Saucepan(GetVolume(), inventoryNumber));
			break;
	case 5:
			as = insert(as, new Multivariate(GetIsPressureCooker(), GetVolume(), GetPower(), GetColor(), inventoryNumber));
			break;
	}
}

void PrintInvNum(node *tree)
{
	if (!tree) return;
	PrintInvNum(tree->left);
	cout << tree->key->inventoryNumber << " (" << PrintType(tree -> key) << ")  ";
	PrintInvNum(tree->right);
}

int main()
{
	setlocale(LC_ALL, "Russian");
	
	cout << "������������!!! ������ ���������� ���������� �������� ������� ���� ��� �������������!\n\n";
	while (true)
	{
		cout << "\n��� �������?\n\t1 - �������� ������� | 2 - ������� ������ � �������� | 3 - ������� ������� | 4 - ������� ���� ������ ��������� | 5 - �����\n";
		bool f = false;
		switch (GetNum(5))
		{
		case 1: Add(); break;
		case 2: PrintElem(); system("pause"); break;
		case 3: DeleteElem(); break;
		case 4: PrintAllElem(); system("pause"); break;
		case 5: f = true; break;
		default:
			break;
		}
		if (f) break;
		system("cls");
		cout << "-------------------------------------------------------------------------------------------------------------------------\n";
		cout << "� �������� �������� � ��������: ";
		PrintInvNum(as);
		cout << "\n-------------------------------------------------------------------------------------------------------------------------\n";
	}

	DeleteTree(as);
	return 0;
}