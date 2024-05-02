# Лабораторная 1

# Отрабатываемый материал

Инкапсуляция, сокрытие, композиция, полиморфизм, интроспекция, SOLID

# Цель

Освоить основные принципы ООП, применить на практике знания о работе с объектно-ориентированным кодом на C#

# Задание

- Реализовать объектную модель симулятора фэнтезийного космического передвижения
- Покрыть полученное решение модульными тестами

# Формулировка

Отделу космических исследований необходима система для расчётов продолжительности космических маршрутов в различных средах, а так же расчётов возможности и оптимальности прохождения данных маршрутов определёнными типами кораблей.

## Среды

- обычный космос
для перемещения в данной среде кораблей необходимо иметь импульсный двигатель.
- туманности повышенной плотности пространства
для перемещения в данной среде импульсные двигатели имеют достаточно малую эффективность, поэтому их использование нецелесообразно. к тому же, такие туманности имеют большую пространственную площадь, поэтому перемещения через них возможно лишь по специальным подпространственным каналам. эти каналы имеют определённую длину, поэтому чтобы по ним пройти, корабль должен иметь возможность пройти канал **полностью**, **сделать это в два захода не получится**. для перемещения по подпространственным каналам необходимы специальные прыжковые двигатели.
- туманности нитринных частиц
для перемещения в данной среде кораблей необходимо иметь импульсный двигатель. контакт с нитринными частицами снижает эффективность работы импульсных двигателей, поэтому для оптимального прохождения через такие туманности, необходимо использовать импульсные двигатели экспоненциального ускорения.

Каждая среда **может** содержать соответствующее ей препятствие.

## Двигатели

- Импульсный двигатель класса C
стандартный импульсный двигатель. выдаёт константную скорость средней величины, имеет достаточно низкое потребление топлива (активной плазмы).
- Импульсный двигатель класса E
импульсный двигатель экспоненциального ускорения. выдаёт скорость, экспоненциально растущую на протяжении ускорения корабля данным двигателем. такое поведение требует больший расход топлива, чем для двигателя класса C.
- Прыжковый двигатель
существует несколько классов прыжковых двигателей (Alpha, Omega, Gamma), различаются дальностью хода по подпространственным каналам и формулой расчёта потребления специального топлива – гравитонной материи. Alpha – линейный расход, Omega – логарифмический (~n log n), Gamma – квадратичный.

Запуск импульсных двигателей всегда потребляет определённое количество топлива.

Цена топлива задаётся на Топливной Бирже и считается в кредитах Добывающей Гильдии.

## Препятствия

- Метеориты и мелкие астероиды
встречаются в обычном космосе, наносят низкий урон дефлекторам корабля, урон корпусу рассчитывается из его прочности и соотношения масса-габаритных характеристик корабля к препятствию.
- Вспышки антиматерии
встречаются в подпространственных каналах. для отражения данного препятствия корабль должен быть оснащён специальными фотонными дефлекторами, урон корпусу не наносят, но, их не отражённое фотонными дефлекторами воздействие, приведёт к гибели экипажа.
- Космо-киты
встречаются в туманностях нитринных частиц, т.к. питаются ими. наносят критический урон дефлекторам корабля, а так же уничтожают его, в случае отсутствие дефлекторов, в силу своих монструозных габаритов.  для избежания контакта с космо-китами может быть использован анти-нитринный излучатель, он маскирует сигнал нитринных-частиц, что приводит к тому, что зона следования корабля становится для них не привлекательной территорией. могут встречаться с различной плотностью популяции (различное количество столкновений за одно препятствие)

## Корабли

- Прогулочный челнок
Простой корабль оснащённый импульсным двигателем класса C. Не имеет дефлекторов, имеет корпус класса прочности 1 и малые масса-габаритные характеристики.
- Ваклас
Исследовательский корабль. Оснащён импульсным двигателем класса E и прыжковым двигателем класса Gamma, имеет дефлекторы класса 1, корпус класса прочности 2 и средние масса-габаритные характеристики.
- Мередиан
Добывающий корабль. Оснащён импульсным двигателем класса E и анти-нитринным излучателем, имеет дефлекторы класса 2, корпус класса прочности 2 и средние масса-габаритные характеристики.
- Стелла
Дипломатический корабль. Оснащён импульсным двигателем класса C и прыжковым двигателем класса Omega, имеет дефлекторы класса 1, корпус класса прочности 1 и малые масса-габаритные характеристики.
- Авгур
Боевой корабль. Оснащён импульсным двигателем класса E и прыжковым двигателем класса Alpha, имеет дефлекторы класса 3, корпус класса прочности 3 и большие масса-габаритные характеристики.

## Дефлекторы

- класс 1
выдерживают урон, наносимый двумя мелкими астероидами или одним метеоритом, после отражения этих препятствий – отключаются
- класс 2
выдерживают урон, наносимый десятью мелкими астероидами или тремя метеоритами, после отражения этих препятствий – отключаются
- класс 3
выдерживают урон, наносимый 40 мелкими астероидами, десятью метеоритами или одним космо-китом, после отражения этих препятствий – отключаются
- фотонные дефлекторы
модификация дефлекторов, позволяющая отражать 3 вспышки антиматерии. может быть установлена на любой класс дефлекторов.

## Классы прочности корпуса

- класс 1
выдерживает урон, наносимый одним мелким астероидом, любой дальнейший урон приводит к уничтожению корабля
- класс 2
выдерживает урон, наносимый пятью мелкими астероидами или двумя метеоритами, любой дальнейший урон приводит к уничтожению корабля
- класс 3
выдерживает урон, наносимый 20 мелкими астероидами или пятью метеоритами, любой дальнейший урон приводит к уничтожению корабля

## Маршрут

- Состоит из нескольких отрезков пути
- Отрезок пути представляет собой расстояние и какую-либо среду
- Результатом прохождения может быть
    - Успех
    Содержит время прохождения маршрута, истраченное на данном пути топливо
    - Потеря корабля
    Происходит в случае нехватки дальности прыжкового двигателя
    - Уничтожение корабля
    - Гибель экипажа

# Definition of done

- Реализована объектная модель описанных сущностей
- В среды могуть быть добавлены только разрешённые препятствия
- Реализован механизм расчёта прохождения маршрута кораблями. Обрабатываются возможные результаты операций, выбирается наиболее оптимальный для прохождения корабль, отсутствие подходящих кораблей так же должно быть отображено в логике.

# Test cases

- Маршрут средней длины в туманности повышенной плотности пространства. Обработать два корабля (`[Theory]`): Прогулочный челнок и Авгур. Первый не имеет прыжковых двигателей, второй имеет недостаточную дальность. Оба не должны завершить маршрут.
- Вспышка антиматерии в подпространственном канале. Обработать два корабля (`[Theory]`):  Ваклас и Ваклас с фотонными дефлекторами. В первом случае маршрут не должен быть пройден из-за потери экипажа, во втором – пройден.
- Космо-кит в туманности нитринных частиц. Обработать три корабля (`[Theory]`): Ваклас, Авгур и Мередиан. Первый – уничтожен после столкновения, второй – только потерял щиты, третий – был не тронут.
- Короткий маршрут в обычном космосе. Запускаем Прогулочный челнок и Ваклас. Т.к. у Вакласа большая стоимость полёта, то Прогулочный челнок должен быть оптимальнее для данного маршрута.
- Маршрут средней длины в туманности повышенной плотности пространства. Запускаем Авгур и Стеллу. Т.к. у Авгура возможная дальность прохождения по подпространственным каналам меньше – должна быть выбрана Стелла.
- Маршрут в туманости нитринных частиц. Запускаем Прогулочный челнок и Ваклас. Должен быть выбран Ваклас.
- Маршрут из нескольких отрезков пути с препятсвиями и без. Детали маршрута реализуются по усмотрению студента.

# Лабораторная 2

### Отрабатываемый материал

**Применение порождающих паттернов**, решение задач, связанных с созданием сущностей или групп похожих сущностей.

# Задание

- Реализовать объектную модель “конфигуратора” персонального компьютера и существующих вариантов комплектующих.
- Реализовать механизмы
    - валидации готовой сборки
    - формирования заказа для отдела продаж
    - оповещений о проблемах несовместимости, отказа от гарантийных обязательств, замечаний/комментариев.
- Покрыть полученное решение модульными тестами

# Формулировка

Интернет магазину по продаже компьютерных комплектующих понадобился инструмент для подбора и создания готового системного блока. Необходимо реализовать «***Конфигуратор***», для того чтобы собрать из имеющегося набора деталей ***компьютеры*** для дальнейшей передачи заказов в отдел продаж. Основным требованием заказчика является возможность подбора **совместимых** комплектующих для осуществления продаж покупателям.

Сборка компьютера является сложным и чётко организованным процессом, состоящим из нескольких этапов, таких как подбор оборудования и проверка совместимости. Рядовой покупатель может не обладать знаниями о всех тонкостях процесса сборки ПК, поэтому необходимо удостоверится в том что комплектующие имеют физическую совместимость, всем компонентам достаточно энергопотребления и доступные шины/слоты удовлетворяют требованиям различных компонентов перед тем отправить такую сборку в отдел продаж для дальнейшей реализации.

Так же, существуют случаи когда покупатель просто хочет подобрать готовую систему и заменить лишь пару компонентов (например более мощную видеокарту), поэтому необходимо предусмотреть возможность запуска “конфигуратора” на базе какой-либо платформы (к примеру Amd Ryzen последнего поколения или Intel i7 на базе чипсета X99 и т.п.).

## Компонентная база

Обязательные комплектующие отмечены звездочкой*

### Материнская плата*

Это главная плата компьютера, соединяющая все компоненты системного блока в одно логическое целое. Её открытая архитектура позволяет собрать систему самому. Любой модуль, будь то процессор, оперативная память или видеокарта, имеет соответствующий только ему разъём, куда подаётся необходимое электропитание.

В зависимости от используемой платы и её **чипсета** вводятся ограничения на совместимость с другими частями, такими как процессор (в виду различий по [сокету](https://te4h.ru/sokety-dlya-protsessorov-intel)) и оперативная память (слоты под разные версии шины имеют различное количество контактов на печатной плате).

**Атрибуты:**

 - Сокет процессора

 - Кол-во распаянных на плате PCI-E линий

 - Кол-во распаянных на плате SATA портов

 - Чипсет (доступные частоты памяти, поддержка XMP)

 - Поддерживаемый стандарт DDR

 - Кол-во столов под ОЗУ

 - Форм-фактор

 - BIOS (Тип, Версия)

### Процессор*

CPU – это «мозг» компьютера. Он состоит из нескольких миллионов транзисторов, сгруппированных в ядра. Каждое ядро ЦП способно обрабатывать отдельную задачу, поэтому их количество и тактовая частота непосредственно влияют на общую производительность. Важно понимать, что не каждый процессор, можно установить в конкретную материнскую плату, даже если сокет совпадает и есть физическая возможность разместить процессор на материнской плате, производитель/вендор может не поддерживать более новые версии вышедшие для конкретной платформы [(см. таблицу совместимости в качестве примера)](https://amd.news/obzor/sovmestimost-ryzen-socket-am4/). Данная проверка реализуется внутри встроенного компонента называемым BIOS. Это набор микропрограмм, реализующих низкоуровневые API для работы с аппаратным обеспечением компьютера, если процессор не поддерживает тот API который использует BIOS на материнской плате, то такой вариант сборки ПК не запустится.

**Атрибуты**:

 - Частота ядер

 - Кол-во ядер

 - Сокет

 - Наличие встроенного видеоядра

 - Поддерживаемые частоты памяти

 - Тепловыделение (TDP)

 - Потребляемая мощность (в ватт)

### BIOS

**BIOS - Basic Input/Output System.**

Именно этот компонент занимается тем что применяет настройки и согласует частоты на которых будут работать все компоненты компьютера.

Известно, что не каждый процессор запустится на материнской плате, даже при условии совместимости сокета. Покупая процессор и материнскую плату новички, смотрят на поддержку чипсета и совместимость сокета, это правильно, но не гарантирует, что такая "связка" запустится. Это потому, что, выпуская материнскую плату, например, в 2022 году производитель не знает о процессоре, выпущенном в 2023 году. Конечно это устраняется путем корректирования БИОС, но тут важно учесть, что для обновления BIOS компьютер должен работать, а потому важно еще на этапе покупки процессора быть уверенным, что БИОС поддерживает выбранную модель процессора. Набор микропрограмм материнских плат отличаются по "прошивке". Поэтому еще на этапе сборки важно знать с какими процессорами совместима купленная материнская плата.

**Атрибуты:**

- Тип

- Версия

- Список поддерживаемых процессоров

### **Система охлаждения процессора***

Система охлаждения компьютера — набор средств для отвода тепла от нагревающихся в процессе работы компьютерных компонентов. Данные системы обладают конкретными пиковыми величинами максимально возможной рассеиваемой массе тепла. В случаях, когда на достаточно производительный процессор устанавливается слабая система охлаждения могут происходить сбои в работе, но при этом, такой вариант сборки необходимо разрешить к продаже, добавив соответствующий комментарий об отказе ответственности от гарантийных обязательств, т.к. покупатель может эксплуатировать данную систему (не смотря на нарушения рекомендаций об эксплуатации).

**Атрибуты:**

 - Габариты

 - Поддерживаемые сокеты

 - Максимально рассеиваемая масса тепла (TDP)

### Оперативная память*

ОЗУ выполняет функцию временного хранителя данных, которые нужны для работы процессора в конкретный момент времени. Ключевые показатели «оперативки» выражаются **скоростью** приёма/передачи информации и объёмом хранимых данных. Чем они выше тем эффективнее работа CPU. При этом, нужно понимать, что “быстрая” память может работать в не до конца совместимых с ней материнских платах, на более медленных частотах, но не наоборот. Если есть проблемы с совместимостью материнская плата самостоятельно подберет из списка доступных ближайшую рабочую частоту. Так работает DRAM по стандартам JEDEC. Также на планках памяти устанавливается микросхема с прошивкой. Производитель вписывает в нее несколько профилей в виде «частота/тайминги», из которых компьютер выбирает подходящий режим для стабильной работы системы.  Но от базовых стандартов его отличают максимальные рабочие настройки. Если JEDEC ограничивает характеристики микросхем на уровне технологии DDR, то XMP — это частный случай для каждой модели, за который отвечает только производитель этого комплекта.

**Атрибуты:**

 - Количество доступного размера памяти

 - Поддерживаемые пары частот JEDEC и вольтажа

 - Доступные XMP/DOСP(A-XMP) профили

 - Форм-фактор

 - Версия стандарта DDR

 - Потребляемая мощность (в ватт)

### XMP Profile

XMP — аббревиатура от Extreme Memory Profiles. Это технология, разработанная Intel специально для быстрого разгона оперативной памяти. У AMD есть аналогичная технология — DOCP (Direct Overclock Profile)

Профиль содержит характеристики которые можно **применить** к конкретному модулю памяти **для модификации** его характеристик и **блокировки** непосредственно тех **значений**, которые заданы в профиле, не смотря на поддерживаемые пары JEDEC. 

<aside>
💡 При покупке памяти, совместимой с XMP, необходимы также материнская плата, совместимая с XMP, и центральный процессор, который поддерживает указанные скорости.

</aside>

**Атрибуты**:

 - Тайминги (ex. 18-18-36-54)

 - Вольтаж

 - Частота

** - Обязательный компонент при невыполнении конкретных условий.

### Видеокарта **

Графический адаптер выводит изображение на монитор компьютера. Данное устройство обязательно в сборках где процессор не имеет встроенного видеоядра, т.к. без возможности вывода изображения покупатель не сможет пользоваться компьютером.  

**Атрибуты:**

- Высота и ширина видеокарты

- Количество видеопамяти

- Версия PCI-E

- Частота чипа 

- Потребляемая мощность (в ватт)

### SSD накопитель **

Это твердотельное устройство хранения информации. Быстродействие у SSD-накопителя значительно выше чем у жёсткого диска, поэтому его целесообразно использовать для систем в высоком ценовом сегменте.

**Атрибуты:**

 - Вариант подключения (PCI-E / Sata)

 - Ёмкость в Гб

 - Максимальная скорость работы

 - Потребляемая мощность (в ватт)

### Жесткий диск **

HDD – это устройство хранения информация. Скорость вращения дисков «винчестера» непосредственно влияет на комфорт пользователя от работы с ОС. Низкий уровень шума, высокая отказоустойчивость и оптимальное соотношение цена/объём определили HDD как устройство для сохранения важной информации.

**Атрибуты:**

 - Ёмкость в Гб

 - Cкорость вращения шпинделя

 - Потребляемая мощность (в ватт)

** Сборка должна содержать как минимум один из видов накопителя, иначе покупатель не сможет установить операционную систему.

### Корпус*

Корпус системного блока служит местом установки блока питания ПК, его рабочих модулей, материнской планы и прочих вспомогательных компонентов. Основным свойством является размеры. Необходимо проверять что выбранная покупателем материнская плата с установленным куллером помещается внутрь и боковая крышка может закрываться без соприкосновений с тепловыми трубками системы охлаждения процессора.

**Атрибуты**:

 - Максимальная длина и ширина видеокарты

 - Поддерживаемые форм-факторы материнских плат

 - Габариты

### Блок питания*

В некоторой степени блок питания выполняет функции стабилизации и защиты от незначительных помех питающего напряжения. Мощность, отдаваемая в нагрузку БП, зависит от мощности компьютерной системы и варьируется в пределах от 300 (офисные платформы малых форм-факторов) до пары тысяч Вт (наиболее высокопроизводительные рабочие станции, серверы или мощные игровые машины). В случаях, когда покупатель устанавливает блок с недостаточной мощностью, необходимо считать такую сборку невалидной. Также, производители комплектующих часто завышают показатели потребляемого количества мощности, поэтому при несоблюдении **рекомендуемых** мощностей, можно оповещать об этом покупателя и отпускать такую сборку в отдел продаж. 

**Атрибуты:**

 - Пиковая нагрузка (в ватт)

### Wi-Fi адаптер

Wi-Fi адаптеры представляют собой специальные устройства, которые используются для подсоединения к беспроводной сети. Этот компонент является опциональным, но, при попытке его добавления в компьютер, материнская плата которого, уже имеет встроенный Wi-Fi модуль, необходимо считать такую сборку не валидной, в виду конфликта сетевого оборудования.

**Атрибуты:**

 - Версия стандарта WiFi

 - Наличие встроенного модуля Bluetooth

 - Версия PCI-e

 - Потребляемая мощность

 

## Acceptance criteria

- Реализован контракт для работы с “конструктором”
- Реализованы все бизнес правила проверяющие совместимость оборудования в процессе создания сборки
- Реализована возможность изменения компонентов ранее созданной сборки.
- Unit-тесты

## Функциональные требования (Что ваше решение должно уметь делать)

- Создание новых компонентов
    - с нуля (например выпуск новой видеокарты, ранее не существовавшей в природе)
    - на базе уже имеющихся (например новая материнская плата с обновленным BIOS)
- Регистрация новых компонентов в репозитории существующих на рынке комплектующих
- Возможность создания сборки ПК с использованием имеющейся компонентной базы
    - Формирование чек-листа для проверки совместимости комплектующих между собой поэтапно
        - Поддержать установку строгого порядка установки комплектующих
        - Попытка установки комплектующих до установки всех предварительных требований - исключительная ситуация.
    - Запуск проверок и получение результата сборки { Успешность результата, замечания/комментарии, отказ от гарантийных обязательств }
- Возможность создания сборки ПК на базе предыдущей сборки

## Test cases

- Попытка сборки из точно совместимого комплектующего должна проходить без отказе от гарантийных обязательств и ошибок
- Попытка сборки из совместимого комплектующего с заявленным потреблением больше чем максимально доступное, но достаточного для запуска системы должно проходить с предупреждением.
- Попытка сборки с совместимым кулером, но с недостаточной мощностью рассеивания тепла производимого процессом должна проходить с обязательным выставлением комментария при передаче заказа в отдел продаж.
- Попытка сборки несовместимого комплектующего в различных вариациях должна заканчиваться неудачей с указанием чётких причин.

Выбор конкретных значений для различных компонентов системы (частота оперативной памяти, название вендоров оборудования, сокеты и т.д.) отдаётся на откуп студенту, главное сохранить корректность значений согласно условиям лабораторной и **здравому смыслу в реальном мире**.

# Лабораторная 3

# Отрабатываемый материал

Основные принципы ООП, GRASP, SOLID, порождающие паттерны, структурные паттерны, mocking.

# Цель

Отработать реализацию структурных паттернов, применить их совместно с ранее изученным материалом.

# Задание

- Реализовать объектную модель корпоративной системы распределения сообщений, используя на практике отрабатываемый теоретический материал
- Покрыть полученное решение функциональными авто-тестами

# Формулировка

Некоторая компания разрабатывает корпоративную систему распределения сообщений. Предметная область, которую компания автоматизирует, имеет сложный механизм формирования адресатов, а так же набор различных конечных точек для сообщений.

# Функциональные требования

## Сообщение

- Имеет заголовок
- Имеет тело
- Имеет уровень важности

## Топик

- Имеет название
- Имеет адресата
- В топик можно отправить сообщение, он должен передать его адресату

## Адресат

- В адресат можно передать сообщение
- Адресаты бывают нескольких видов
    - Адресат-пользователь
    Передает сообщение пользователю корпоративной системы
    - Адресат-мессенджер
    Отправляет сообщение используя сторонний мессенджер
    - Адресат-дисплей
    Выводит сообщение на какое-либо физическое устройство отображения
    - Адресат-группа
    Содержит в себе несколько адресатов, передаёт каждому из них полученные сообщения
- Необходимо иметь возможность фильтровать сообщения для конкретных адресатов по их уровню важности
- Необходимо иметь возможность логгировать сообщения, получаемые конкретным адресатом

## Пользователь

- Является конечной точкой сообщения
- Пользователь может иметь некоторые атрибуты (не обязательно для контекста лабораторной)
- Должна быть возможность отправить пользователю сообщение
- Пользователь должен отслеживать полученные сообщения, и их статус (прочитано, не прочитано) (статус сообщения существует только в контексте пользователя)
- Пользователь должен иметь возможность отметить сообщение прочитанным
Отметить такое сообщение можно только в статусе не прочитано, попытка отметить прочитанное сообщение должна обрабатываться

## Мессенджер

- Является конечной точкой сообщения
- Должен иметь возможность выводить текст 
Для целей лабораторной можно просто выводить текст в консоль с припиской “мессенджер”

## Дисплей

- Является конечной точкой сообщения
- Должен иметь возможность выводить текст заданного цвета
Дисплей должен держать лишь одно сообщение, поэтому перед выводом его необходимо очищать

## Дисплей-драйвер

- Должен иметь возможность очистить вывод
- Должен иметь возможность задать цвет выводимого текста
- Должен иметь возможность записать текст

# Не функциональные требования

- Реализация логгирования должна быть тестируемой
например, проверить вывод на консоль при вызове некоторых поведений в авто-тестах - невозможно
нужно иметь возможность реализовать в тестах mock-тип, который будет вести счётчик вызовов
- Реализация мессенджера и дисплея должна быть тестируемой
- Реализация мессенджера и дисплея должна быть изолирована
Эти реализации не должны иметь явной или неявной зависимости на логику доставки сообщений, ведь они являются сторонними интеграциями
Их реализации должны находиться в отдельных папках
- Вывод на дисплей должен быть реализован как вывод на консоль так и вывод в файл

# Definition of done

- Реализованы все функциональные требования
- Реализация соответствует всем не функциональным требованиям
- Реализация не нарушает принципы SOLID, следует основным принципам ООП
- Использованы структурные паттерны
- Корректно использован порождающий паттерн
- Реализованы все тест-кейсы

# Test cases

- При получении сообщения пользователем, оно сохраняется в статусе “не прочитано”
- При попытке отметить сообщение пользователя в статусе “не прочитано” как прочитанное, оно должно поменять свой статус
- При попытке отметить сообщение пользователя в статусе “прочитано” как прочитанное, должна вернуться ошибка
- При настроенном фильтре для адресата, отправленное сообщение, не подходящее под критерии важности - до адресата дойти не должно
(в данном тесте необходимо использовать моки)
- При настроенном логгировании адресата, должен писаться лог, когда приходит сообщение
(в данном тесте необходимо использовать моки)
- При отправке сообщения в месенджер, его реализация должна производить ожидаемое значение
(в данном тесте необходимо использовать моки)

# Лабораторная 4

# Отрабатываемый материал

SOLID, поведенческие, структурные, порождающие паттерны 

# Цель

Проверить освоение студентом принципов SOLID, паттернов проектирования.

# Задание

Разработать приложение для взаимодействия и управления файловой системой.

# Функциональные требования

- Навигация по дереву файловой системы (относительные и абсолютные пути)
- Просмотр содержимого каталога в консоли
- Просмотр содержимого файлов в консоли
- Перемещение файлов
- Копирование файлов
- Удаление файлов
- Переименование файлов
- Консольный механизм взаимодействия с приложением
- Реализация операций для локальной файловой системы

# Не функциональные требования

- Система должна поддерживать взаимодействие посредством консольных команд, имеющих флаги.
- Логика работы системы не должна быть привязана к обработке консольных команд.
- Система должна поддерживать возможность расширения параметров консольных команд.
- Обработка команд не должна быть привязана к консоли.
- Система не должна быть завязана на локальную файловую систему.
- Вывод содержимого каталога должен быть параметризован глубиной выборки (значение по умолчанию - 1)
- Вывод системного каталога должен быть в виде дерева.
- Параметры выводимого дерева (символы обозначающие файл, папку, символы используемые для отступов должны быть программно параметризуемыми).
- Логика вывода содержимого каталога не должна быть завязана на консоль.
- Логика вывода содержимого файла не должна быть завязана на консоль.
- Система должна адекватно обрабатывать случаи коллизий имён.
- Система должна уметь переключаться между файловыми системами (например смена диска C, на диск D).
- После вывода результата на консольный интерфейс, программа должна ожидать ввод следующей команды.
- Для реализации системы нельзя использовать какие-либо сторонние библиотеки

# Глоссарий

- Относительный путь - путь от текущего положения, выбранного в системе
- Абсолютный путь - путь от положения, в которое изначально было сделано подключение

# Семантика команд

- connect [Address] [-m Mode]
Address - абсолютный путь в подключаемой файловой системе
Mode - режим файловой системы (требуется реализовать только локальную ФС, значение `local`)
- disconnect
Отключается от файловой системы
- tree goto [**Path**]
**Path** - относительный или абсолютный путь до каталога в файловой системе
- tree list {-d **Depth**}
**Depth** - параметр, определяющий глубину выборки, должен объявляться флагом `-d`
- file show [**Path**] {-m **Mode**}
**Path** - относительный или абсолютный путь до файла
**Mode** - режим вывода файла (требуется реализовать только консольный, значение `console`)
- file move [**SourcePath**] [**DestinationPath**]
**SourcePath** - относительный или абсолютный путь до перемещаемого файла
**DestinationPath** - относительный или абсолютный  путь до директории, куда файл должен быть перемещён
- file copy [**SourcePath**] [**DestinationPath**]
**SourcePath** - относительный или абсолютный путь до копируемого файла
**DestinationPath** - относительный или абсолютный путь до директории, куда файл должен быть скопирован
- file delete [**Path**]
**Path** - относительный или абсолютный путь до удаляемого файла
- file rename [**Path**] [**Name**]
**Path** - относительный или абсолютный путь до изменяемого файла
**Name** - новое имя файла

# Test cases

- Протестировать парсер команд: обработка консольных команд с аргументами должна создавать команду корректного типа с корректными аргументами

# Definition of done

- Реализованы все функциональные требования
- Реализация соответствует всем не функциональным требованиям
- Реализация не нарушает принципы SOLID, следует основным принципам ООП
- Реализован консольный интерфейс работы с приложением

# Лабораторная 5

# Отрабатываемый материал

Многослойные архитектуры, паттерны

# Цель

Проверить освоение студентом многослойных архитектур

# Задание

Реализовать систему банкомата

# Функциональные требования

- создание счета
- просмотр баланса счета
- снятие денег со счета
- пополнение счета
- просмотр истории операций

# Не функциональные требования

- интерактивный консольный интерфейс
- возможность выбора режима работы (пользователь, администратор)
    - при выборе пользователя должны быть запрошены данные счета (номер, пин)
    - при выборе администратора должен быть запрошен системный пароль
        - при некорректном вводе пароля - система прекращает работу
- системный пароль должен быть параметризуем
- при попытке выполнения некорректных операций, должны выводиться сообщения об ошибке
- данные должны быть персистентно сохранены в базе данных (PostgreSQL)
- использование каких-либо ORM библиотек - запрещено
- приложение должно иметь хексагональную архитектуру
    - опционально: можно реализовать луковую архитектуру с богатой доменной моделью.

# Test cases

- снятие денег со счёта
    - при достаточном балансе проверить что сохраняется счёт с корректно обновлённым балансом
    - при недостаточном балансе сервис должен вернуть ошибку
- пополнение счёта
    - проверить что сохраняется счёт с корректно обновлённым балансом

Данные тесты должны проверять бизнес логику, они не должны как-либо зависить от базы данных или консольного представления.

В данных тестах необходимо использовать моки репозиториев.
