Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение:
- пользователь вводит элементы через запятую
- программа парсит через запятую как отдельные элементы
- создается массив длины как исходный
- по каждому элементу массива проходит проверка на длину в 3 символа, если подходит, то кладем в отдельный массив
- собираем из финального массива все элементы и печатаем их через запятую