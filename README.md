# VisualStudioTesting_Markelov

Практическая работа №1 по теме **«Средства тестирования Visual Studio 2022»**.

**Студент:** Маркелов Игорь Вячеславович  
**Группа:** ИПО-21  
**Операционная система:** Windows 11

---

## Описание работы

Данная практическая работа выполнена по материалам руководства **«Средства тестирования Visual Studio-2022»** (стр. 158–170) и посвящена созданию и запуску **модульных тестов** для класса `BankAccount`.

В ходе работы реализован проект с банковским счётом и тестовый проект, проверяющий поведение метода `Debit`.

---

## Что проверяется в работе

Согласно заданию, для метода `Debit` класса `BankAccount` необходимо проверить три основных сценария:

1. Метод должен создавать исключение `ArgumentOutOfRangeException`, если сумма списания **превышает баланс**.
2. Метод должен создавать исключение `ArgumentOutOfRangeException`, если сумма списания **меньше нуля**.
3. Если сумма списания допустима, метод должен **корректно уменьшать баланс счёта**.

---

## Структура проекта

```text
VisualStudioTesting_Markelov/
├── VisualStudioTesting_Markelov.sln
├── src/
│   └── BankAccountMarkelov/
│       ├── BankAccountMarkelov.csproj
│       └── BankAccount.cs
├── tests/
│   └── BankAccountMarkelov.Tests/
│       ├── BankAccountMarkelov.Tests.csproj
│       └── BankAccountTests.cs
└── docs/
    └── report.md
```

---

## Назначение проектов

### `BankAccountMarkelov`
Основной проект, содержащий класс `BankAccount`.

В классе реализованы:

- поле баланса;
- имя владельца счёта;
- метод `Debit(double amount)`;
- метод `Credit(double amount)`;
- константы сообщений об ошибках:
  - `DebitAmountExceedsBalanceMessage`
  - `DebitAmountLessThanZeroMessage`
  - `CreditAmountLessThanZeroMessage`

### `BankAccountMarkelov.Tests`
Тестовый проект на базе **MSTest**, содержащий модульные тесты для проверки поведения метода `Debit`.

---

## Реализованные тесты

В проекте `BankAccountMarkelov.Tests` реализованы следующие тестовые методы:

### 1. `Debit_WithValidAmount_UpdatesBalance`
Проверяет, что при корректной сумме списания баланс уменьшается на нужную величину.

### 2. `Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange`
Проверяет, что при отрицательной сумме списания метод `Debit` создаёт исключение `ArgumentOutOfRangeException`.

### 3. `Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange`
Проверяет, что при попытке списать сумму, превышающую остаток на счёте, метод `Debit` создаёт исключение `ArgumentOutOfRangeException`.

---

## Используемые технологии

Для выполнения практической работы используются:

- **Microsoft Visual Studio 2022**
- **C#**
- **.NET 8**
- **.NET SDK 8.0**
- **MSTest**
- **Test Explorer**
- **Git**
- **GitHub**

---

## Требования к среде

Для открытия и запуска проекта рекомендуется:

- Windows 11
- Visual Studio 2022
- установленная рабочая нагрузка:
  - **.NET desktop development**
- установленный **.NET SDK 8.0**

---

## Как открыть проект

1. Запустите **Visual Studio 2022**.
2. Выберите **Open a project or solution**.
3. Откройте файл:

```text
VisualStudioTesting_Markelov.sln
```

---

## Как собрать решение

В Visual Studio 2022:

1. Откройте решение.
2. Выберите:

```text
Build → Build Solution
```

или используйте сочетание клавиш:

```text
Ctrl + Shift + B
```

---

## Как запустить тесты

Чтобы выполнить тесты:

1. Откройте решение в Visual Studio 2022.
2. Перейдите в меню:

```text
Test → Test Explorer
```

3. В окне **Test Explorer** нажмите:

```text
Run All
```

или используйте сочетание клавиш, если оно доступно в вашей конфигурации Visual Studio.

После запуска:

- зелёный индикатор означает, что тесты пройдены успешно;
- красный индикатор означает, что хотя бы один тест завершился с ошибкой.

---

## Ожидаемый результат выполнения тестов

При корректной реализации метода `Debit`:

- тест на валидное списание должен пройти успешно;
- тест на отрицательную сумму должен пройти успешно;
- тест на сумму, превышающую баланс, должен пройти успешно.

Если в коде метода `Debit` допущена ошибка (например, сумма прибавляется к балансу вместо вычитания), тест `Debit_WithValidAmount_UpdatesBalance` не пройдёт, что демонстрирует работу модульного тестирования.

---

## Что должно быть в сопроводительной записке

Сопроводительная записка должна содержать:

1. титульный лист;
2. оглавление;
3. описание цели работы;
4. постановку задачи;
5. описание среды разработки;
6. описание класса `BankAccount`;
7. описание написанных тестов;
8. результаты выполнения тестов;
9. скриншоты:
   - структуры решения;
   - исходного кода;
   - тестового проекта;
   - окна **Test Explorer**;
10. заключение;
11. список использованных источников.

Итоговый файл необходимо сохранить в формате **PDF**.

---

## Что нужно загрузить на GitHub

В репозиторий рекомендуется загрузить:

- solution-файл `.sln`;
- исходный проект `BankAccountMarkelov`;
- тестовый проект `BankAccountMarkelov.Tests`;
- папку `docs`;
- итоговую записку в формате PDF;
- данный файл `README.md`.

---

## Что не нужно загружать

Не рекомендуется загружать:

- `bin/`
- `obj/`
- `.vs/`
- временные пользовательские файлы Visual Studio

---

## Рекомендуемое имя репозитория

Можно использовать, например:

```text
practice-1-visual-studio-testing-markelov
```

или

```text
visual-studio-testing-markelov
```

---

## Как загрузить проект на GitHub

### Вариант через терминал

Находясь в папке проекта, выполните:

```bash
git init
git add .
git commit -m "Add practice work 1 BankAccount testing project"
git branch -M main
git remote add origin https://github.com/USERNAME/REPOSITORY.git
git push -u origin main
```

Где:

- `USERNAME` — ваш логин GitHub;
- `REPOSITORY` — имя репозитория.

---

## Отправка преподавателю

После загрузки проекта на GitHub ссылку на репозиторий необходимо отправить на адрес:

```text
crhunta@outlook.com
```

### Тема письма

```text
ИПО-21, Маркелов Игорь Вячеславович
```

### Пример текста письма

```text
Здравствуйте!

Направляю ссылку на репозиторий GitHub с выполненной практической работой №1.

Студент: Маркелов Игорь Вячеславович
Группа: ИПО-21

Ссылка на репозиторий:
[вставить ссылку]

С уважением,
Маркелов Игорь Вячеславович
```

---

## Срок сдачи

Согласно заданию, срок сдачи практической работы №1:

```text
27.02.2026
```

---

## Полезные материалы

- https://learn.microsoft.com/ru-ru/visualstudio/test/
- https://metanit.com/sharp/tutorial/
- https://learn.microsoft.com/ru-ru/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022

---

## Примечание

Если при открытии проекта Visual Studio предложит установить или обновить платформу, рекомендуется установить **.NET SDK 8.0** и необходимые компоненты разработки для .NET.

---