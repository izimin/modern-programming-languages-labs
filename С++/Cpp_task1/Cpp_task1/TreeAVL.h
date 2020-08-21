#pragma once
#include "Classes.h"

// структура для представления узлов дерева
struct node 
{
	Kitchenware* key;
	node* left;
	node* right;
	int height;																	// У каждого узла будем хранить его высоту
	node(Kitchenware* k) { key = k; left = right = 0; height = 1; }				// Конструктор (Дерево из одного узла имеет высоту 1)
	~node()	{ delete key; }														// Деструктор
};

// Получаем высоту у узла (если null то и высота соответственно 0)
int getHeight(node* p)
{
	return p ? p->height : 0;
}

// Вычисление дисбаланса узла (разница междду выотами левого и правого поддерева)
int disbalance(node* p)
{
	return getHeight(p->right) - getHeight(p->left);
}

// Изменение текущей высоты узла
void changeHeight(node* p)
{
	int hl = getHeight(p->left);
	int hr = getHeight(p->right);
	p->height = (hl>hr ? hl : hr) + 1;
}

// Малый правый поворот     (логика названий узлов "downNode" потому что мы будем этот узел "опускать", "upDown" - "поднимать")   
node* RR(node* downNode) 
{
	node* upNode = downNode->left;				// Создаём указатель на узел (левое поддерево), который будет родителем текущего узла
	downNode->left = upNode->right;				
	upNode->right = downNode;
	changeHeight(downNode);
	changeHeight(upNode);
	return upNode;
}

// Малый левый поворот
node* LL(node* downNode)
{
	node* upNode = downNode->right;
	downNode->right = upNode->left;
	upNode->left = downNode;
	changeHeight(downNode);
	changeHeight(upNode);
	return upNode;
}

// Балансировка узла 
node* balanceNode(node* p)
{
	changeHeight(p);
	if (disbalance(p) == 2)						// Правое поддерево выше на 2 узла → требуется балансировка (RL или LL)
	{
		if (disbalance(p->right) < 0)			// Случай когда требуется "RL поворот" то есть у правого поддерева левое поддерево выше 
			p->right = RR(p->right);			// Выполняем правый поворот у правого поддерева
		return LL(p);							// И левый у текущего узла
	}
	if (disbalance(p) == -2)					// Левое поддерево выше на 2 узла → требуется балансировка (LR или RR)
	{
		if (disbalance(p->left) > 0)			// Случай когда требуется "LR поворот" то есть у левого поддерева правое поддерево выше 
			p->left = LL(p->left);				// Выполняем левый поворот у левого поддерева
		return RR(p);							// И левый у текущего узла 
	}
	return p;									// Дисбаланс допустим (+1, -1, 0)
}

// Вставка ключа в дерево 
node* insert(node* p, Kitchenware* k) 
{
	// Итак всё просто, без комментариев
	if (!p) return new node(k);
	if (k->inventoryNumber < p->key->inventoryNumber)
		p->left = insert(p->left, k);
	else
		p->right = insert(p->right, k);
	return	balanceNode(p);
}

node* findmin(node* p) // поиск узла с минимальным ключом в дереве p 
{
	return p->left ? findmin(p->left) : p;
}

node* removemin(node* p) // удаление узла с минимальным ключом из дерева p
{
	if (!(p->left))
		return p->right;
	p->left = removemin(p->left);
	return balanceNode(p);
}

node* remove(node* p, int k) // удаление придмета с инвентарным номером k
{
	if (!p) return NULL;
	if (k < p->key->inventoryNumber)
		p->left = remove(p->left, k);
	else if (k > p->key->inventoryNumber)
		p->right = remove(p->right, k);
	else 
	{
		node* l = p->left;
		node* r = p->right;
		delete p;
		if (!r) return l;					// узел - лист или имеет только левое поддерево 
		node* min = findmin(r);				// минимальный узел правого поддерева удаляемого узла
		min->right = removemin(r);
		min->left = l;
		return balanceNode(min);
	}
	return balanceNode(p);
}

// Определяем при помощи dynamic_cast к какому типу относится объект 
string PrintType(Kitchenware* a)
{
	if (dynamic_cast<Multivariate*>(a)) return "Мультиварка";
	if (dynamic_cast<GasStove*>(a)) return "Газовая плита";
	if (dynamic_cast<ElectricStove*> (a)) return "Электрическая плита";
	if (dynamic_cast<Saucepan*>(a)) return "Кастрюля";
	if (dynamic_cast<Stove*>(a)) return "Плита";
}

// Печатаем тип предмета и вызывам метод print класса этого объекта
void PrintKey(node* tree)
{
	cout << PrintType(tree->key) << endl;
	tree->key->print(true);
	cout << "-------------------------------------------------------------------------------------------------------------------------\n";
}

void DeleteTree(node * tree)
{
	if (!tree) return;
	DeleteTree(tree->left);
	DeleteTree(tree->right);
	delete tree;
}
// Прямой обход  "Корень - левое - правое"
void ShowKLR(node* tree)
{
	if (!tree) return;
	PrintKey(tree);
	ShowKLR(tree->left);
	ShowKLR(tree->right);
}

//Обратный обход "Левое - правле - корень"
void ShowLRK(node* tree)
{
	if (!tree) return;
	ShowLRK(tree->left);
	ShowLRK(tree->right);
	PrintKey(tree);
}

// Симметричный обход "Левое - корень - правое"
void ShowLKR(node* tree)
{
	if (!tree) return;
	ShowLKR(tree->left);
	PrintKey(tree);
	ShowLKR(tree->right);
}