# calculator-Anton-Samoshuk
calculator-Anton-Samoshuk 
Application for counting numbers, developed in Windows Forms in C#
Лабораторная работа №1 ВСРПП. Выполнил Самошук Антон Юрьевич гр. 20ИТ-2.
Внешний вид калькулятора:


![image](https://user-images.githubusercontent.com/105459589/197389156-0fbb8f91-38ce-4749-8161-696a1a89c194.png)


Выполнены Юнит тесты:


![image](https://user-images.githubusercontent.com/105459589/197389204-f6204615-0231-42a1-a88c-2f5bf9a6875c.png)


Проект представляет собой обычный калькулятор. Можно использовать сложение, вычитанеи, умножение и деление:


![Без имени](https://user-images.githubusercontent.com/105459589/197389246-dd5fc282-e592-4590-b0c0-b6032501d0d5.png)


Если нужно, можно изменить знак числа с помощью кнопки "+/-:"


![1](https://user-images.githubusercontent.com/105459589/197389298-a3e967f4-9086-489a-9d2a-6c36ee334803.png)

Обозначение методов и классов:

Class Formacal // класс с помогательнымии и визуальными методами

private void C_Click(object sender, EventArgs e)//стриает все данные
 
public string Add(int a, string dis)//добавдение числа
  
private void plusmins_Click_1(object sender, EventArgs e)//отрицательное или положительное число
   
private void equals_Click_1(object sender, EventArgs e)//Кнопка вычисления
    
public void Simvols(string sim, out bool simvol)// Выбор знака 




Class Calculate// класс с арифметическими методами

public string DoCalculate(int count, double numo, double displayf)// арифметический метод

public string backer(string display)// убирает один символ

