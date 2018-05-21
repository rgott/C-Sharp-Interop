#include <stdio.h>
#include <string>
#include <iostream>

extern "C" // no name mangling
{
	__declspec(dllexport) int add(int a, int b)
	{
		return a + b;
	}
}

__declspec(dllexport) void Run(char *message)
{
	std::cout << message << " -From C++" << std::endl;
}

