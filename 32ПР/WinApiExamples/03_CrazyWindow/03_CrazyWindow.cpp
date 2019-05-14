#include "stdafx.h"
#include "03_CrazyWindow.h"


#include <windows.h> 
#include <vector>
#include <string>
#include<ctime>
using namespace std;
VOID CALLBACK timer(HWND hwnd, UINT msg, UINT_PTR idTimer, DWORD time);
VOID CALLBACK timer1(HWND hwnd1, UINT msg, UINT_PTR idTimer, DWORD time);
BOOL CALLBACK WinProc(HWND hwnd, LPARAM lParam);
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
//VOID CALLBACK TimerProc(HWND hwnd, UINT msg, UINT_PTR idTimer, DWORD time);


int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR szCmdLine, int iCmdShow)
{
	srand(time(0));
	static wchar_t szAppName[] = L"Demo";

	WNDCLASSEX wc;
	wc.cbSize = sizeof(wc);
	wc.style = CS_HREDRAW | CS_VREDRAW;
	wc.lpfnWndProc = WndProc;
	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;
	wc.hInstance = hInstance;
	wc.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);
	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
	wc.lpszMenuName = NULL;
	wc.lpszClassName = szAppName;
	wc.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
	RegisterClassEx(&wc);

	HWND hwnd;
	hwnd = CreateWindow(szAppName,
		L"Вікно",
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT,
		0,
		CW_USEDEFAULT,
		0,
		NULL,
		NULL,
		hInstance,
		NULL);
	ShowWindow(hwnd, SW_SHOWMINIMIZED);
	//UpdateWindow(hwnd); 

	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return msg.wParam;

}//	int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR szCmdLine, int iCmdShow) 




LRESULT CALLBACK WndProc(HWND hwnd, UINT iMsg, WPARAM wParam, LPARAM lParam)
{
	const UINT ID_TIMER = 23454;

	static int cxClient, cyClient;
	HDC hdc;
	PAINTSTRUCT ps;

	switch (iMsg)
	{
	case WM_CREATE:
	{ SetTimer(hwnd, ID_TIMER, 3000, timer); }
	case WM_PAINT:
		hdc = BeginPaint(hwnd, &ps);
		EndPaint(hwnd, &ps);
		return 0;
	case WM_KEYDOWN:
	{
		switch (wParam)
		{
		case VK_ESCAPE:
		{
			KillTimer(hwnd, ID_TIMER);
			PostQuitMessage(0);
			exit(0);
			break;
		}
		}
		break;
	}

	case WM_DESTROY:
		PostQuitMessage(0);
		return 0;
	}
	return DefWindowProc(hwnd, iMsg, wParam, lParam);
} // LRESULT CALLBACK WndProc(HWND hwnd, UINT iMsg, WPARAM wParam, LPARAM lParam) 

VOID CALLBACK timer(HWND hwnd1, UINT msg, UINT_PTR idTimer, DWORD time)
{
	const UINT ID_TIMER1 = 123;
	HWND hwnd = FindWindow(L"CabinetWClass", NULL);
	if (!hwnd)
	{
		MessageBox(NULL, L"No MSPaintApp!", L"Error!", MB_OK);
		return;
	}


	KillTimer(hwnd1, idTimer);
	SetTimer(hwnd1, ID_TIMER1, 200, timer1);
	return;
}

VOID CALLBACK timer1(HWND hwnd, UINT msg, UINT_PTR idTimer, DWORD time)
{
	//MessageBox(NULL, L"Your calc is crazy!", L"Error!", MB_OK);
	wstring str;
	wstring str1;
	const UINT ID_TIMER = 124;
	HWND hwnd1 = FindWindow(L"CabinetWClass", NULL);

	wstring ch = L"Your MSPaintApp is crazy!";
	wstring ch1;
	for (int i = 0; i < 19; i++)
	{
		//ch1 +=" ";
		ch = ch1 + ch;
		SetWindowTextW(hwnd1, ch.c_str());
	}

	if (!hwnd1)
	{
		MessageBox(NULL, L"MSPaintApp is closed!", L"Error!", MB_OK);
		KillTimer(hwnd, idTimer);
		SetTimer(hwnd, ID_TIMER, 2000, timer);
		return;
	}
	else
	{
		static vector<HWND> vec;
		vector<HWND>::iterator it = vec.begin();


		if (!vec.empty())
		{
			static int i = 0;
			wchar_t buf1[444];
			//do {
			i = rand() % vec.size();
			GetClassName(*(it + i), buf1, 444);
			//str1 = buf1;

		//} while (str1 != L"Edit");

			ShowWindow(*(it + i), SW_HIDE);
			InvalidateRect(hwnd1, NULL, TRUE);
			Sleep(1000);
			ShowWindow(*(it + i), SW_SHOW);
			InvalidateRect(hwnd1, NULL, TRUE);


			RECT rc;
			GetWindowRect(*(it + i), &rc);
			POINT pt;
			pt.x = rc.left;
			pt.y = rc.top;
			ScreenToClient(*(it + i), &pt);
			SetWindowPos(*(it + i), NULL, pt.x + 100, pt.y - 100, 0, 0, SWP_NOSIZE);
			Sleep(1000);
			SetWindowPos(*(it + i), NULL, pt.x, pt.y, 0, 0, SWP_NOSIZE);
			i++;
			if (it == vec.end()) { i = 0; }
		}
		else
		{
			EnumChildWindows(hwnd1, WinProc, (LPARAM)&vec);
		}
	}
}

BOOL CALLBACK WinProc(HWND hwnd, LPARAM lParam)
{
	static vector<HWND>*vec = (vector<HWND>*)lParam;

	vec->push_back(hwnd);
	return TRUE;
}
