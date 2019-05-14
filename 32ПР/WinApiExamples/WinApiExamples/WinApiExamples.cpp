#include "stdafx.h"
#include "WinApiExamples.h"
#include<Windows.h>
//#include "Resource.h"


LRESULT CALLBACK DlgProc(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam);


int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrev, LPSTR szCmdLine, int nShowCmd)
{
	int rez = IDABORT;
	rez = MessageBox(NULL, L"Текст для MessageBox'а", L"Заголовок вікна", MB_YESNOCANCEL | MB_ICONINFORMATION);
	switch (rez)
	{
	case IDYES:
	{
		MessageBox(NULL, L"Ви натиснули Yes!", L"MessageBox", MB_OK | MB_ICONINFORMATION);
		break;
	}
	case IDNO:
	{
		MessageBox(NULL, L"Ви натиснули No!", L"MessageBox", MB_OK | MB_ICONINFORMATION);
		break;
	}
	case IDCANCEL:
	{
		MessageBox(NULL, L"Ви натиснули Cancel!", L"MessageBox", MB_OK | MB_ICONINFORMATION);
		break;
	}
	case IDABORT:
	{
		MessageBox(NULL, L"Ви натиснули x!", L"MessageBox", MB_OK | MB_ICONINFORMATION);
		break;
	}
	default:
		MessageBox(NULL, L"Я не знаю що ви натиснули!", L"MessageBox", MB_OK | MB_ICONINFORMATION);
	}

	LPCTSTR Caption = L"Application Programming Interface";


	MessageBox(NULL,
		L"Welcome to Win32 Application Development\n"
		L"You will learn about functions, classes, "
		L"communication, and other cool stuff\n"
		L"Are you ready to rumble!!!!!!!!!!!!!!",
		Caption,
		MB_YESNOCANCEL | MB_ICONQUESTION);

	HWND hwnd = NULL;
	DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1),
		hwnd, reinterpret_cast<DLGPROC>(DlgProc));

	return 0;
}

//
////---------------------------------------------------------------------------
LRESULT CALLBACK DlgProc(HWND hWndDlg, UINT Msg, WPARAM wParam, LPARAM lParam)
{
	switch (Msg)
	{
	case WM_INITDIALOG:
		return TRUE;

	case WM_COMMAND:
	{
		switch (wParam)
		{
		case IDOK:
			EndDialog(hWndDlg, 0);
			return TRUE;
		case IDCANCEL:
			MessageBox(NULL, L"no", L"mess box", MB_DEFAULT_DESKTOP_ONLY);
			break;
		case IDC_BUTTON1:
			MessageBox(NULL, L"BUTTON 1", L"mess box", MB_DEFAULT_DESKTOP_ONLY);
			break;
		}

	}
	}
	return FALSE;
}