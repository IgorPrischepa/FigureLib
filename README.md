# Тестовое задание

## Задача №1:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника
по трем сторонам. Дополнительно к работоспособности оценим:

<ul>
<li>Юнит-тесты</li>
<li>Легкость добавления других фигур</li>
<li>Вычисление площади фигуры без знания типа фигуры в compile-time</li>
<li>Проверку на то, является ли треугольник прямоугольным</li>
</ul>

## Решение
Для того чтобы добавить новую фигуру необходимо наследоваться от [```Firgure```](https://github.com/IgorPrischepa/FigureLib/blob/master/Contracts/Figure.cs), после чего реализовать метод [```CalcArea()```](https://github.com/IgorPrischepa/FigureLib/blob/94a496e9ac82645021220a857bab81251c1b2656/Contracts/Figure.cs#L9).

Конструктор новой фигуры должен принимать ```params double[]```.

В методе [```CalcArea()```](https://github.com/IgorPrischepa/FigureLib/blob/4060b33217620adcb6de8a24c92231d65dc9f176/FigureHelper.cs#L21) реализовано определение типа фигуры во время выполенния.

В папке [FigureLob.Test](https://github.com/IgorPrischepa/FigureLib/tree/master/FigureLib.Tests) располагаются юнит тесты для типов фигур в библиотеке. 

### Примеры

```csharp
//Вызов расчёта площади треугольника

FigureHelper.CalcArea<Triangle>(4,4,5)

//Вызов расчёта площади круга

FigureHelper.CalcArea<Circle>(5)

//Проверка является ли треугольник прямоугольным

FigureHelper.IsRightTriangle(3, 4, 5)
```

## Задача №2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

##Решение
Была создаана следущая БД:

<img width="530" alt="image" src="https://user-images.githubusercontent.com/5076626/232894814-55683095-64e5-4a21-8979-4ad13b60a6aa.png">

Сприпт для создания БД в файле [```Db_create.sql```](https://github.com/IgorPrischepa/FigureLib/blob/master/Db_create.sql) , инициализация данными [```Db_init.sql```](https://github.com/IgorPrischepa/FigureLib/blob/master/Db_init.sql).

[Запрос](https://github.com/IgorPrischepa/FigureLib/blob/master/Requierd_Request.sql):</br>
<img width="399" alt="image" src="https://user-images.githubusercontent.com/5076626/232895395-31210f15-34c7-4c79-a9fe-627197e0e559.png">

Результат запроса:</br>
<img width="123" alt="image" src="https://user-images.githubusercontent.com/5076626/232895522-1173aa4e-a8e6-447a-aedf-14d794b7143f.png">
