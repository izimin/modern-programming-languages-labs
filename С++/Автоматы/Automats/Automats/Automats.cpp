// Automats.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#define SYNC 0xAA

struct Pack
{
	int AW[6];
	short TaTw[8];
	unsigned char Status,Number;
	unsigned char crc[2];
};
int _tmain(int argc, _TCHAR* argv[])
{
	FILE *fin;
	if (fopen_s(&fin,"data.bin","rb"))
	{
			printf("Error opening file");
			return 1;
	}
	unsigned char curByte;
	printf("   Ax      |    Ay     |Sta\n");
	while (!feof(fin))
	{
		fread(&curByte,1,1,fin);
		if (curByte != SYNC)
			continue;
		fread(&curByte,1,1,fin);
		if (curByte != SYNC)
			continue;
		fread(&curByte,1,1,fin);
		if (curByte != 45)
			continue;
		fread(&curByte,1,1,fin);
		if (curByte != 0x87)
			continue;
		unsigned char data[44];
		fread(&data,1,44,fin);
		struct Pack p;
		memcpy(&p,data,44);
		printf("%11d|%11d|%3d\n",p.AW[0],p.AW[1],p.Status);
		//break;
	}

	return 0;
}

