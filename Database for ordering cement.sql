-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Дек 12 2022 г., 13:01
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `proizcement`
--

-- --------------------------------------------------------

--
-- Структура таблицы `city`
--

CREATE TABLE `city` (
  `id` int(2) UNSIGNED NOT NULL,
  `city` varchar(30) NOT NULL,
  `distance` int(5) NOT NULL,
  `price` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `city`
--

INSERT INTO `city` (`id`, `city`, `distance`, `price`) VALUES
(1, 'Москва', 1154, 18000),
(2, 'Саратов', 971, 15300),
(3, 'Ижевск', 222, 4875),
(4, 'Владивосток', 5284, 28042),
(5, 'Санкт-Петербург', 1491, 21345);

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE `clients` (
  `id` int(3) UNSIGNED NOT NULL,
  `name` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `login` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `clients`
--

INSERT INTO `clients` (`id`, `name`, `surname`, `login`, `password`) VALUES
(1, 'Никита', 'Сидоров', 'SidrNikita', 'qwertygg'),
(2, 'Кирилл', 'Иванов', 'IvanKirill', '666');

-- --------------------------------------------------------

--
-- Структура таблицы `markandinfo`
--

CREATE TABLE `markandinfo` (
  `id` int(3) UNSIGNED NOT NULL,
  `marka` varchar(50) NOT NULL,
  `info` varchar(2000) NOT NULL,
  `Price` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `markandinfo`
--

INSERT INTO `markandinfo` (`id`, `marka`, `info`, `Price`) VALUES
(1, 'ЦЕМ I 42,5 Н СС', 'ЦЕМ I — быстротвердеющий портландцемент с количеством добавок не более 5%; требуется не более 2-х суток, чтобы бетон достиг нужной прочности;\r\n42,5 – класс прочности на сжатие, соответствует 42,5 МПа. Также маркируется цифрой 500.\r\nН – нормально твердеющий;\r\nДО – минеральные добавки отсутствуют.', 478),
(3, 'ЦЕМ II/А-Ш 42,5Н', 'Портландцемент типа ЦЕМ II, подтипа А со шлаком (Ш) от 6 % до 20 %, класса прочности 42,5 нормальнотвердеющий. Используется в производстве бетонов классов до B30 включительно, производстве товарного бетона для монолитных массивных сооружений, производстве сухих строительных смесей массового применения, производстве ячеистого бетона, производстве железобетонных изделий, подвергающихся пропариванию.\r\n\r\nОбласти применения:\r\n\r\nВозведение фундамента, внутренние штукатурные работы, грубое выравнивание полов;\r\nСтроительство уличных и домашних бассейнов;\r\nИзготовление элементов декора;\r\nВозведение внутренних перекрытий и лестниц;\r\nЗатирка швов;\r\nУкладка кирпича, блоков и плитки.', 633),
(4, 'Белый цемент (БЦ) (ГОСТ 965-78)', 'изготовляют из маложелезистого клинкера (серый цвет обычного цемента обусловлен главным образом наличием соединений железа в исходных сырьевых материалах). Для повышения белизны и устранения зеленоватых оттенков клинкер подвергается отбеливанию.\r\nПо вещественному составу подразделяют на белый портландцемент и белый портландцемент с минеральными добавками. Выпускают марок 400 и 500. Содержание минеральных добавок в белом портландцементе не допускается, а в портландцементе с минеральными добавками не должно быть более 20%, в том числе инертных — более 10% от массы портландцемента. \r\nБелый цемент является материалом с уникальными характеристиками, которые позволяют использовать его в изготовлении скульптурных элементов, колонн, а также при отделочных работах, например, фасада здания. Эстетические требования, предъявляемые к фасадам и другим парадным строительным элементам, делают применение белого цемента особенно эффективным.\r\nБелый цемент применяют также для цветных цементнобетонных дорожных покрытий, например на площадях у монументальных сооружений.', 521),
(5, 'Цветной портландцемент (ГОСТ 15825-80)', 'получают из клинкера белого цемента, цветного клинкера, а также из отбеленных клинкеров путем тщательного смешивания или совместного помола с пигментами различных цветов (например, с охрой, железным суриком, оксидом хрома).\r\nПигменты должны быть щелоче- и светостойкими. Цветные портландцементы бывают желтые, розовые, красные, коричневые, зеленые, голубые и черные. Белый и цветные портландцемеиты, способствующее архитектурно-декоративному оформлению сооружений, применяют при устройстве мозаичных и плиточных облицовок, террацциевых покрытий полов и полов из мраморной или гранитной брекчии, а также для изготовления мозаичных изделий и бетонных фасадных плит.', 322);

-- --------------------------------------------------------

--
-- Структура таблицы `quantity`
--

CREATE TABLE `quantity` (
  `id` int(3) UNSIGNED NOT NULL,
  `quantity` int(4) NOT NULL,
  `price` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `quantity`
--

INSERT INTO `quantity` (`id`, `quantity`, `price`) VALUES
(1, 50, 12),
(2, 100, 25),
(3, 500, 47),
(4, 1000, 86);

-- --------------------------------------------------------

--
-- Структура таблицы `size`
--

CREATE TABLE `size` (
  `id` int(3) UNSIGNED NOT NULL,
  `size` int(4) NOT NULL,
  `price` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `size`
--

INSERT INTO `size` (`id`, `size`, `price`) VALUES
(1, 50, 21),
(2, 100, 32),
(3, 250, 41),
(4, 500, 65),
(5, 1000, 83);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `city`
--
ALTER TABLE `city`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `markandinfo`
--
ALTER TABLE `markandinfo`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `quantity`
--
ALTER TABLE `quantity`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `size`
--
ALTER TABLE `size`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `city`
--
ALTER TABLE `city`
  MODIFY `id` int(2) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(3) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `markandinfo`
--
ALTER TABLE `markandinfo`
  MODIFY `id` int(3) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `quantity`
--
ALTER TABLE `quantity`
  MODIFY `id` int(3) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `size`
--
ALTER TABLE `size`
  MODIFY `id` int(3) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
