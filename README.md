
![.NET](https://github.com/Giviruk/Actions/actions/workflows/dotnet.yml/badge.svg)
[![codecov](https://codecov.io/gh/DMak80/Actions/branch/HW11/graph/badge.svg?token=AJ1EHK3XZH)](https://codecov.io/gh/DMak80/Actions)

# Домашняя работа №11 - Dynamic

## Теория
1.  [Карлен Симонян — Эффективное использование DLR](https://www.youtube.com/watch?v=lltDIUQrjgY)
2.  [Multiple dispatch в C#](https://habr.com/ru/post/283522/)

## Вопросы к семинару
1.  Что такое CallSite?
2.  Во что разворачивается dynamic d = 100 при компиляции
3.  Что такое “адаптивный кеш”, как он реализован?
4.  Что представляет собой техника “multiple dispatch”? Как можно реализовать multiple dispatch в C# на основе dynamic?

## Практика
1.  Переписать ExpressionVisitor из прошлой домашней работы используя технику multiple dispatch. Наследовать базовый ExpressionVisitor из стандартной библиотеки запрещено
2.  Добавить обработку ошибок на основе multiple dispatch. Обрабатывать разными способами по крайней мере 3 разных типа ошибок
3.  Внедрить ILogger в зависимости, логировать ошибки в базовом классе ExceptionHandler
