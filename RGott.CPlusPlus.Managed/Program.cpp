#pragma once

namespace RGott
{
	namespace CPlusPlus
	{
		namespace Managed
		{
			public ref class Program
			{
			public:
				static int Add(int a, int b)
				{
					return a + b;
				}

				static void Run(System::String^ message)
				{
					System::Console::Write(message);
					System::Console::WriteLine(" -From Managed C++");
				}
			};
		}
	}
}