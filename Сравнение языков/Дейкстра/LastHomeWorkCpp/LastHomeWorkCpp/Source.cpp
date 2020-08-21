#include <iostream>
#include <tuple>
#include <vector>
#include <fstream>
#include <set>
#include "time.h"

using namespace std;

int FindInTuple(vector<tuple<int, int, int>>p, int a, int b, int n)
{
	for (int i = 0; i < n; i++)
		if (get<0>(p[i]) == a && get<1>(p[i]) == b && get<2>(p[i]) != 0 && get<2>(p[i]) != -1)
			return get<2>(p[i]);
	return 0;
}

int CountPoints(vector<tuple<int, int, int>>p, int n)
{
	set<int>plenty;
	for (int i = 0; i < n; i++)
		plenty.insert(get<0>(p[i]));
	return plenty.size();
}

int IndexInTuple(vector<tuple<int, int, int>>p, int a, int b, int n)
{
	for (int t = 0; t < n; t++)
		if (get<0>(p[t]) == a && get<1>(p[t]) == b)
			return t;
	return -1;
}

int Dijkctra(int numberPoints, vector<tuple<int, int, int>>data, int n, int Node1, int Node2)
{
	set<int> S; //мн-во непросмотренных вершин
	int *D = new int[numberPoints]; //метки вершин
	int i, j, m, p, k;
	int Max_Sum = 0;
	--Node1; //так как нумераци€ начинаетс€ с 0
	--Node2;

	for (i = 1; i <= numberPoints; i++)
		for (j = 1; j <= numberPoints; j++)
			if (FindInTuple(data, i, j, n) == 0 /*|| FindInTuple(data, i, j, n) == -1*/)
			{
				tuple<int, int, int> t(i, j, INT_MAX);
				data[IndexInTuple(data, i, j, n)] = t;
			}
			/*else if(FindInTuple(data, j, i, n) == 0)
			{
				tuple<int, int, int> t(j, i, INT_MAX);
				data[IndexInTuple(data, j, i, n)] = t;
			}*/


	for (i = 0; i < numberPoints; i++)
	{
		D[i] = INT_MAX;
		S.insert(i);
	}

	p = Node1;
	D[Node1] = 0;
	while (p != Node2)
	{
		for (i = 0; i < numberPoints; i++)
			if (S.find(i) != S.end())
			{
				if (FindInTuple(data, p+1, i+1, n) < INT_MAX)
					if (D[i] > D[p] + FindInTuple(data, p + 1, i + 1, n))
						D[i] = D[p] + FindInTuple(data, p + 1, i + 1, n);
			}
		S.erase(p);
		m = Node2;
		for (i = 0; i < numberPoints; i++)
			if (S.find(i) != S.end())
				if (D[m] > D[i])
					m = i;
		p = m;
	}
	return D[Node2];
}

int main()
{
	setlocale(LC_ALL, "Russian");
	fstream f;
	f.open("test2.txt");
	int n;
	f >> n;
	vector<tuple<int, int, int>> data(n);

	for (int i = 0; i < n; i++)
	{
		int a, b, c;
		f >> a >> b >> c;
		tuple<int, int, int> graphPart(a, b, c);
		data[i] = graphPart;
	}
	f.close();
	int numberPoints = CountPoints(data, n);
	cout << "¬ведите вершины, между которыми будем искать рассто€ние: ";
	int Node1, Node2;
	cin >> Node1 >> Node2;
	if ((Node1 >= 1 && Node2 >= 1)
		&& (Node2 <= numberPoints && Node1 <= numberPoints))
	{
		time_t t1 = clock();
		int path = Dijkctra(numberPoints, data, n, Node1, Node2);
		time_t t2 = clock();
		if (path == INT_MAX)
			cout << -1 << endl;
		else
			cout << path << endl;
		cout << (double)(t2 - t1)/CLOCKS_PER_SEC;
	}
	else
		cout << "Ќеверный ввод!" << endl;
	system("pause");

}
