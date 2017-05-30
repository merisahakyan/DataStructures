// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include <iostream>
#include <string>
#include "Queue.h"
using namespace std;


void main()
{
	Queue<int> bo;
	
	bo.enqueue(2);
	bo.enqueue(3);
	bo.enqueue(4);
	cout << bo.frontPtr->date;
	cout << bo.backPtr->date;

}
