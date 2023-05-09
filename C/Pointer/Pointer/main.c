#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdint.h>


void printParameterPointerAdress(uint8_t* a)
{
	printf("printParameterPointerAdress:\n");
	
	printf("Adress: 0x%p\n",(void*) &a);
}

void printPointerAdress(uint32_t a)
{
	printf("Adress: 0x%x\n", a);
}

void printPointerValue(uint32_t *a)
{
	printf("Adress: 0x%p\n", (void*) a);
}

void printDereferenz(uint32_t* a)
{
	printf("Adress: %d\n", *a);
}

void Subtraction(uint8_t *a, uint8_t *b, uint8_t *pRes)
{
	static uint8_t res = 0;
	printf("Subtraction\n");

	printf("Pointer-Adressen der Funktionsparameter:\n");
	printParameterPointerAdress(a);
	printParameterPointerAdress(b);
	printParameterPointerAdress(pRes);

	
	printf("Pointer Adressen:\n");


}


void Subtraction_byRef(const uint8_t *a, uint8_t *b, uint8_t *pRes)
{
	static uint8_t res = 0;
	printf("Subtraction by ref\n");

	printf("Pointer-Adressen:\n");
	printPointerAdress(a);
	printPointerAdress(b);
	printPointerAdress(pRes);


	printf("Pointer Adressen:\n");


}


void main()
{

	uint8_t* p1=0;
	uint8_t* p2=0;
	uint8_t* pRes=0;

	uint8_t a = 2;
	uint8_t b = 3;

	p1 = &a;
	p2 = &b;
	Subtraction(&a, &b, pRes);
	
	printf("main:\n");
	printf("Pointer-Adressen der Funktionsparameter:\n");

	printParameterPointerAdress(p1);
	printParameterPointerAdress(p2);
	printParameterPointerAdress(pRes);

	Subtraction_byRef(p1, p2, pRes);




}