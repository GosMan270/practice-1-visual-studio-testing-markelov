# VisualStudioTesting_Markelov

Практическая работа №1 по теме **«Средства тестирования Visual Studio»**.

**Студент:** Маркелов Игорь Вячеславович  
**Группа:** ИПО-21

---

## Описание работы

Данная практическая работа выполнена по материалам руководства **«Средства тестирования Visual Studio»** (стр. 158–170) и посвящена созданию и запуску **модульных тестов** для класса `BankAccount`.

В ходе работы реализован проект с банковским счётом и тестовый проект, проверяющий поведение метода `Debit`.

---

## Что проверяется

Для метода `Debit` класса `BankAccount` проверяются три сценария:

1. При допустимой сумме списания баланс корректно уменьшается.
2. При отрицательной сумме списания создаётся исключение `ArgumentOutOfRangeException`.
3. При сумме, превышающей баланс, создаётся исключение `ArgumentOutOfRangeException`.

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
    ├── report.md
    └── images/
```

---

## Используемые технологии

- **Microsoft Visual Studio**
- **C#**
- **.NET 9**
- **MSTest**
- **Test Explorer**

---

## Сборка

1. Открыть `VisualStudioTesting_Markelov.sln` в Visual Studio.
2. `Build` → `Build Solution` (или `Ctrl + Shift + B`).

---

## Запуск тестов

1. `Test` → `Test Explorer`.
2. Нажать `Run All`.

Ожидаемый результат: **3 теста, 3 пройдены**.

---

## Реализованные тесты

| Тест | Назначение |
|---|---|
| `Debit_WithValidAmount_UpdatesBalance` | Проверка корректного списания |
| `Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange` | Проверка отрицательной суммы |
| `Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange` | Проверка превышения баланса |

---

## Сопроводительная записка

Готовая сопроводительная записка в формате PDF находится в файле `docs/report.pdf`.

Исходный markdown-файл записки находится в `docs/report.md`, а иллюстрации — в `docs/images/`.