#include "stdafx.h"
#include "02_MakeWindow.h"


// прототип віконної процедури -- функції, котра обробляє повідомлення вікна
LRESULT CALLBACK WindowProcedure(HWND, UINT, WPARAM, LPARAM);

// точка входу - WinMain(...)
int WINAPI WinMain(HINSTANCE	hInstance		// хендл екземпляра програми
	, HINSTANCE	hPrevInstance	// хендл попереднього екземпляра
	, PSTR		szCmdLine		// вказівник на рядок з параметрами командного рядка
	, int		iCmdShow		// параметр початкового розміру вікна (SW_...)
)
{
	wchar_t		szNameOfApplication[] = L"Моє перше справжнє вікно";
	wchar_t		szNameOfWindowClass[] = L"MyWindowClass";

	//////////////////////      I.   описуємо віконний клас        ///////////////////////////
	WNDCLASSEX	wc;
	wc.cbSize = sizeof(WNDCLASSEX);					// розмір структури у байтах
	wc.style = CS_VREDRAW | CS_HREDRAW;				// стиль вікна : хочемо щоб вікно перемальовувалося при зміні розмірів по горизонталі і вертикалі
	wc.lpfnWndProc = WindowProcedure;						// вказівник на віконну процедуру
	wc.cbClsExtra = 0;									// к-ть байт, що резервуються слідом за структурою класу
	wc.cbWndExtra = 0;									// к-ть байт, що резервуються слідом за екземпляном вікна
	wc.hInstance = hInstance;							// хендл додатку, що створив вікно (нашої проги)
	wc.hIcon = LoadIcon(NULL, IDI_QUESTION);			// визначає значок вікна
	wc.hIconSm = LoadIcon(NULL, IDI_WARNING);	// визначає малий значок вікна
	wc.hCursor = LoadCursor(NULL, IDC_HAND);		// визначає вигляд курсора миші
	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);	// визначає тло вікна
															//wc.hbrBackground= (HBRUSH)GetStockObject( GRAY_BRUSH);	// визначає тло вікна
															//wc.hbrBackground= CreateSolidBrush( RGB( 255, 255, 0 ) ); 
															//wc.hbrBackground= CreateSolidBrush( RGB( 24, 77, 111 ) ); 
	wc.lpszMenuName = NULL;									// визначає меню вікна
	wc.lpszClassName = szNameOfWindowClass;					// визначає ім'я віконного класу

															// RegisterClassEx( &wc );		// ------- реєструємо віконний клас, щоби одержати помилку ;)

															////////////////////       II.  реєструємо віконний клас зі властивостями, описаними в структурі wc   ///////////////////
	if (!RegisterClassEx(&wc))
	{
		MessageBox(NULL, L"Не вдалося зареєструвати віконний клас!", L"Хана!", MB_ICONERROR | MB_OK);
		return 0;
	}

	/////////////////////     III.   Створюємо вікно на основі зареєєстрованого віконного класу     /////////////////////
	HWND hWindow = CreateWindow(
		szNameOfWindowClass,						// ім'я віконного класу, на основі якого створити вікно
		szNameOfApplication,						// Ім'я вікна
		WS_OVERLAPPEDWINDOW /*| WS_VSCROLL*/,		// стиль вікна
		CW_USEDEFAULT,								// х лівого верхнього кута вікна (CW_USEDEFAULT - визначаються системою обидва )
		0,											// y лівого верхнього кута вікна
		CW_USEDEFAULT,								// розмір по X вікна (CW_USEDEFAULT - визначаються системою обидва )
		0,											// розмір по Y вікна 
		NULL,										// хендл батьківського вікна, якщо в третьому параметрі вказно WS_CHILD або WS_CHILDWINDOW
		NULL,										// хендл меню
		hInstance,									// хендл екземпляра програми
		NULL										// lParam для повідомлення WM_CREATE
	);

	if (!hWindow)	// CreateWindow поверне NULL якщо вікно не вдалося створити
	{
		MessageBox(NULL, L"Не вдалося створити вікно!", L"Хана!", MB_ICONERROR | MB_OK);
		return 0;
	}


	/////////////////////     IV.   Відображаємо вікно      ///////////////////////////////////
	ShowWindow(hWindow, iCmdShow);


	/////////////////////      V.   Цикл обробки повідомлень      ///////////////////////////////////
	MSG msg;	// ексземпляр структури повідомлення
	while (GetMessage(&msg, NULL, 0, 0))		// GetMessage() повертає завжди TRUE, крім коли зловить WM_QUIT
	{
		TranslateMessage(&msg);	// "перекладає" повідомлення клавіатури відповідно до поточної розкладки
		DispatchMessage(&msg);	// кладе повідомлення у чергу вікна
	}



	return 0;
}//int WINAPI WinMain(...)




 /////////////////////////////    ВІКОННА ПРОЦЕДУРА     ///////////////////////////////////////
LRESULT CALLBACK WindowProcedure
(HWND hWindow,	// хендл вікна, для котрого надійшла мессага (тобто, одна ВП може обробляти мессаги декількох вікон?)
	UINT iMsg,		// ID повідомлення
	WPARAM wParam,	// параметр одержаного повідомлення
	LPARAM lParam	// ще один параметр одержаного повідомлення
)
{// LRESULT CALLBACK WindowProcedure( HWND, UINT, WPARAM, LPARAM )

	const wchar_t * lpTextUp = L"Натисніть якусь клавішу";
	const wchar_t  *lpTextDown = L"Відпустіть клавішу !";

	static bool isAnyKeyPressed;

	// для кожного виду повідомлень - своя обробка
	switch (iMsg)
	{

	case WM_CREATE:		//  надсилається при створенні вікна ф-єю CreateWindow() --- обробляємо для ініціалізації
		MessageBox(NULL, L"Створюється вікно!", L"УВАГА !", MB_ICONINFORMATION | MB_OK);
		isAnyKeyPressed = false;
		return 0;


	case WM_CLOSE:		//  надсилається коли клацаємо кнопку "Закрити"  ---- виконуємо якісь дії, які необхідні до закриття вікна
		if (IDYES == MessageBox(hWindow, L"Ви справді хочете закрити своє перше вікно ?", L"Невже ?", MB_ICONQUESTION | MB_YESNO))
			break;
		else
			return 0;


	case WM_DESTROY:	//  надсилається коли вікна уже не видно, перед вивільненням пам'яті струтури вікна
		MessageBox(NULL, L"Обробляється повідомлення WM_DESTROY", L"WM_DESTROY", MB_ICONINFORMATION | MB_OK);
		PostQuitMessage(0);	// якщо закриття вікна означає закриття програми --- викликом PostQuitMessage() надсилаємо повідомлення WM_QUIT
		break;



	case WM_PAINT:		//  надсилається щоразу, коли потрібно перемалювати ціле вікно, або його частину
	{
		// 1. отримуємо контекст пристрою ( hdc )
		PAINTSTRUCT ps;
		HDC hdc;
		RECT rectClient, rcText;
		COLORREF col = RGB(255, 100, 100);

		// 2. Малюємо по отриманому контексту
		const wchar_t * lpText = L"Уря-а-а-а! Я\n вмію писати у вікні!!!";


		hdc = BeginPaint(hWindow, &ps);
		GetClientRect(hWindow, &rectClient);
		SetTextColor(hdc, col);
		rcText = rectClient;
		rectClient.top += 100;


		DrawText(hdc, lpText, -1, &rcText, DT_CENTER | DT_VCENTER | DT_CALCRECT);		// обчислюємо прямокутник для малювання тексту --> у rcText

		// ставимо прямокутник для малювання тексту посеред вікна
		int nOffsetX = (rectClient.right - rcText.right) / 2;		// на скільки зсунути його праворуч
		int nOffsetY = (rectClient.bottom - rcText.bottom) / 2;	// на скільки зсунути його донизу
		OffsetRect(&rcText, 100, 100);				// зсуваємо прямокутник rcText, зберігаючи його розмір


		DrawText(hdc, lpText, -1, &rcText, DT_CENTER | DT_VCENTER /*| DT_SINGLELINE*/);	// малюємо текст у прямокутнику rcText (уже посередині вікна)

		if (isAnyKeyPressed)
		{
			DrawText(hdc, lpTextDown, -1, &rcText, DT_CENTER | DT_VCENTER | DT_CALCRECT);		// обчислюємо прямокутник для малювання тексту --> у rcText
			int nOffsetX = (rectClient.right - rcText.right) / 2;		// на скільки зсунути його праворуч
			int nOffsetY = (rectClient.bottom - rcText.bottom) / 2;	// на скільки зсунути його донизу
			OffsetRect(&rcText, nOffsetX, nOffsetY);				// зсуваємо прямокутник rcText, зберігаючи його розмір
			DrawText(hdc, lpTextDown, -1, &rcText, DT_CENTER | DT_VCENTER /*| DT_SINGLELINE*/);	// малюємо текст у прямокутнику rcText (уже посередині вікна)
		}
		else
		{
			DrawText(hdc, lpTextUp, -1, &rcText, DT_CENTER | DT_VCENTER | DT_CALCRECT);		// обчислюємо прямокутник для малювання тексту --> у rcText
			int nOffsetX = (rectClient.right - rcText.right) / 2;		// на скільки зсунути його праворуч
			int nOffsetY = (rectClient.bottom - rcText.bottom) / 2;	// на скільки зсунути його донизу
			OffsetRect(&rcText, nOffsetX, nOffsetY);				// зсуваємо прямокутник rcText, зберігаючи його розмір
			DrawText(hdc, lpTextUp, -1, &rcText, DT_CENTER | DT_VCENTER /*| DT_SINGLELINE*/);	// малюємо текст у прямокутнику rcText (уже посередині вікна)

		}

		// 3. звільняємо контекст пристрою
		EndPaint(hWindow, &ps);
	}
	break;


	case WM_KEYDOWN:
	{
		//MessageBox( NULL, L"Натиснута якась клавіша", L"Є!", MB_ICONINFORMATION );
		//wchar_t buf [555];
		//wsprintf( buf, L"Натиснута якась клавіша. \n Її Virtual-Key Code = %i.\nМабуть це клавіша \'%c\'.", wParam, (wchar_t)wParam );
		//MessageBox( NULL, buf, L"WM_KEYDOWN !", MB_ICONINFORMATION );

		isAnyKeyPressed = true;		// запам'ятовуємо у статичній змінній, що клавіша натиснута

									// примушуємо Windows надіслати повідомлення WM_PAINT, щоби вікно перемалювалося
		RECT rectClient;
		GetClientRect(hWindow, &rectClient);
		//InvalidateRect( hWindow, &rectClient, FALSE ); 
		InvalidateRect(hWindow, &rectClient, TRUE);//чи стирати фон
	}
	break;


	case WM_KEYUP:
	{
		/*MessageBox( NULL, L"Натиснута якась клавіша", L"Є!", MB_ICONINFORMATION );
		wchar_t buf [555];
		wsprintf( buf, L"Відпущена якась клавіша. \n Її Virtual-Key Code = %i.\nМабуть це клавіша \'%c\'.", wParam, (wchar_t)wParam );
		MessageBox( NULL, buf, L"WM_KEYUP !", MB_ICONINFORMATION );*/

		isAnyKeyPressed = false;	// запам'ятовуємо у статичній змінній, що клавіша відпущена

									// примушуємо Windows надіслати повідомлення WM_PAINT, щоби вікно перемалювалося
		RECT rectClient;
		GetClientRect(hWindow, &rectClient);
		////InvalidateRect( hWindow, &rectClient, false ); 
		InvalidateRect(hWindow, &rectClient, TRUE);
	}
	break;


	}// switch( iMsg )


	return DefWindowProc(hWindow, iMsg, wParam, lParam);	// хай стандартна процедура обробить ті повідомлення, які не обробили ми !


}// LRESULT CALLBACK WindowProcedure( HWND, UINT, WPARAM, LPARAM )


