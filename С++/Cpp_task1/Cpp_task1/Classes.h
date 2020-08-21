#pragma once
#include <iostream>
#include <string>

using namespace std;

class Kitchenware abstract
{
public:
    int inventoryNumber;
	Kitchenware(int i)
	{
		inventoryNumber = i;
	}
	virtual void print(bool isFirst)
	{
		if (isFirst)
			cout << "\t������������ �����: " << inventoryNumber << "\n";
	}

	virtual ~Kitchenware() {};
};

class Stove : virtual public Kitchenware
{
public:
	string color;
	Stove(string _color, int _n) : Kitchenware(_n)
	{
		color = _color;
	}
	void print(bool isFirst)
	{
		Kitchenware::print(isFirst);
		cout << "\t����: " << color << "\n";
	}
};

class Saucepan : virtual public Kitchenware
{
public:
	double volume;
	Saucepan(double _volume, int _n) : Kitchenware(_n)
	{
		volume = _volume;
	}
	void print(bool isFirst)
	{
		Kitchenware::print(isFirst);
		cout << "\t��ڨ�: " << volume << "\n";
	}
};

class ElectricStove : public Stove
{
public:
	double power;
	ElectricStove(double _power, string _color, int _n) : Stove(_color, _n), Kitchenware(_n)
	{
		power = _power;
	}
	void print(bool isFirst)
	{
		Stove::print(isFirst);
		cout << "\t��������: " << power << "\n";
	}
};

class GasStove : public Stove
{
public:
	double gasConsumption;
	GasStove(double _gasConsumption, string _color, int _n) : Stove(_color, _n), Kitchenware(_n)
	{
		gasConsumption = _gasConsumption;
	}
	void print(bool isFirst)
	{
		Stove::print(isFirst);
		cout << "\t�������������� ����: "<< gasConsumption << "\n";
	}
};

class Multivariate :  public ElectricStove,  public Saucepan
{
public:
	bool isPressureCooker;
	Multivariate(bool _isPressureCooker, double _volume, double _power, string _color, int _n) : ElectricStove(_power, _color, _n), Saucepan(_volume, _n), Kitchenware(_n)
	{
		isPressureCooker = _isPressureCooker;
	}
	void print(bool isFirst)
	{
		Saucepan::print(true);
		ElectricStove::print(false);
		cout << "\t��������� ������� ����������: ";
		if (isPressureCooker)
			cout << "��\n";
		else cout << "���\n";
	}
};