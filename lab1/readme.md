# Лабораторная работа 1. ИЗУЧЕНИЕ ШИФРОВ МАРШРУТНОЙ ПЕРЕСТАНОВКИ. 

## `1. Цель работы` 

Изучение перестановочных операций шифрования в современных шифросистемах; изучение структуры ключа при использовании шифров перестановки.

## `Постановка задачи`

Дано (таблица кодировки 1251 или 866):
- Файл открытого текста - сообщения М (message.txt); 
- Файл шифротекста – С (cripto.txt);
- Файл ключа – k (key.txt);
- Параметр L1.

Исходные сообщения шифруются шифром маршрутной перестановки с ключом `k=(blocksize, PVector)`, `0 < blocksize <= L1`.

Необходимо: 
1.	Создать программу шифровки и расшифровки заданным вариантом методом;
2.	Зашифровать сообщение `М` с заданным ключом `k1` заданным методом (см. вариант);
3.	Расшифровать сообщение `С` с заданным ключом `k2` заданным методом (см. вариант). Проверить осмысленность полученного сообщения.
4.	Вычислить энтропию исходного и зашифрованного текстов с использованием частот букв и биграмм. Сравнить.
5. Придумать алгоритм для взлома зашифрованного текста на основе имеющихся статистик.

Ключи `k1` и `k2` - содержат `PVector` – как перестановка для зашифрования. 

## `Методические указания`

При шифровании/расшифровании методом маршрутной перестановки алфавит не играет роли, так как производятся только перестановки букв в исходном сообщении. Для этого весь исходный текст разбивается на блоки длины `blocksize` и затем внутри каждого блока происходит перестановка в соответствии с вектором `PVector` при шифровании и с его «обратным» вектором при расшифровании. Таким образом, перед расшифрованием требуется найти обратную для заданной перестановку.

Для вычисления энтропии текста (источника) находятся относительные частоты   появления в тексте `i`-й `k`-граммы (буквы, биграммы). Затем вычисление энтропии `k`-грамм производятся по формуле: 

$$ H_k = - \sum_{\forall i} p_i * log_2 \: p_i $$

После этого вычисляется энтропия сообщения (источника):

$$ H = \frac{H_k}{k} $$

## `Варианты задания`

Для вариантов `1,4,7,10,…` использовать метод маршрутных перестановок с ограничением `L1=64`.

Для вариантов `2,5,8,11,…` использовать метод вертикальных перестановок с ограничением `L1=64`.

Для вариантов `3,6,9,12,…` использовать метод двойных перестановок с ограничениями `L1=64`.

