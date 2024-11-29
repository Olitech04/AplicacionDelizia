-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-11-2024 a las 18:13:21
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `base_delizia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `Direccion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Id`, `Nombre`, `Apellido`, `Telefono`, `Direccion`) VALUES
(10, 'Juan', 'Pérez', '091200001', 'Calle 1 1234, Calle 2'),
(11, 'Lucas', 'Viña', '091200002', 'Calle 1 2345, Calle 2'),
(12, 'Joe', 'Barreto', '333', 'MMMMM'),
(13, 'Joe', 'Barreto', '091234567', 'mmmmmmmmmmm'),
(14, '', '', '', ''),
(15, 'dsadas', 'dsadsa', '123', 'sadsa'),
(16, '', '', '', ''),
(17, 'Andres', 'garcia', '098765432', '125'),
(18, 'Rodrigo ', 'floripondio', '098234651', '346'),
(19, 'qw1', 'frg', '125', '678'),
(20, '124', 'ewewfw', 'dwdwddwds', 'dsdsd');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funcionarios`
--

CREATE TABLE `funcionarios` (
  `Cedula` varchar(10) NOT NULL,
  `Rol` int(11) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Correo` varchar(50) NOT NULL,
  `Contrasena` varchar(20) NOT NULL,
  `Direccion` varchar(20) NOT NULL,
  `Activo` enum('Si','No') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `funcionarios`
--

INSERT INTO `funcionarios` (`Cedula`, `Rol`, `Nombre`, `Apellido`, `Correo`, `Contrasena`, `Direccion`, `Activo`) VALUES
('1', 1, 'Testing', ' ', ' ', 'testing', ' ', 'Si'),
('2', 2, 'Testing', ' ', ' ', 'testing', ' ', 'Si'),
('3', 3, 'Testing', ' ', ' ', 'testing', ' ', 'Si'),
('4', 4, 'Testing', ' ', ' ', 'testing', ' ', 'Si');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funcionariospedidos`
--

CREATE TABLE `funcionariospedidos` (
  `Funcionario` varchar(10) NOT NULL,
  `Pedido` int(11) NOT NULL,
  `Hora` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `funcionariospedidos`
--

INSERT INTO `funcionariospedidos` (`Funcionario`, `Pedido`, `Hora`) VALUES
('1', 5, '0000-00-00'),
('1', 6, '0000-00-00'),
('1', 7, '0000-00-00'),
('1', 8, '0000-00-00'),
('1', 9, '0000-00-00'),
('1', 10, '0000-00-00'),
('1', 11, '0000-00-00'),
('1', 12, '0000-00-00'),
('1', 13, '0000-00-00'),
('1', 14, '0000-00-00'),
('1', 15, '2021-02-28');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funcionariostelefonos`
--

CREATE TABLE `funcionariostelefonos` (
  `Funcionario` varchar(10) NOT NULL,
  `Telefono` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `funcionariostelefonos`
--

INSERT INTO `funcionariostelefonos` (`Funcionario`, `Telefono`) VALUES
('1', '095000001'),
('2', '095000002'),
('3', '095000003'),
('4', '095000004');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `logs`
--

CREATE TABLE `logs` (
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Funcionario` varchar(10) NOT NULL,
  `Equipo` varchar(20) NOT NULL,
  `Tipo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `logs`
--

INSERT INTO `logs` (`Fecha`, `Hora`, `Funcionario`, `Equipo`, `Tipo`) VALUES
('0000-00-00', '10:30:00', '1', 'BXC270014209713', NULL),
('0001-01-01', '00:00:00', '1', 'BXC270014209713', NULL),
('0001-01-01', '12:00:00', '1', 'BXC270014209713', NULL),
('2024-11-17', '22:34:45', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:12:42', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:15:09', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:20:25', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:22:28', '2', 'BXC270014209713', NULL),
('2024-11-18', '00:23:17', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:52:18', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:53:21', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:55:20', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:57:56', '1', 'BXC270014209713', NULL),
('2024-11-18', '01:02:52', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:52:56', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:55:44', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:56:36', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:58:16', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:59:38', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:00:48', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:02:59', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:06:13', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:11:22', '1', 'BXC270014209713', NULL),
('2024-11-18', '15:53:44', '1', 'BXC270014209713', NULL),
('2024-11-18', '16:09:45', '1', 'BXC270014209713', NULL),
('2024-11-19', '16:26:51', '1', 'DESKTOP-MK97VHN', NULL),
('2024-11-19', '18:59:23', '1', 'BXC270014209713', NULL),
('2024-11-19', '18:59:36', '2', 'BXC270014209713', NULL),
('2024-11-19', '18:59:43', '3', 'BXC270014209713', NULL),
('2024-11-19', '19:15:02', '1', 'BXC270014209713', NULL),
('2024-11-19', '19:21:22', '1', 'BXC270014209713', NULL),
('2024-11-19', '21:24:25', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:26:22', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:31:33', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:37:56', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:39:45', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:41:58', '4', 'BXC270014209713', NULL),
('2024-11-19', '22:07:04', '4', 'BXC270014209713', NULL),
('2024-11-19', '22:33:49', '1', 'BXC270014209713', NULL),
('2024-11-19', '22:56:56', '1', 'BXC270014209713', NULL),
('2024-11-19', '22:57:50', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:00:27', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:03:06', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:04:21', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:33:02', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:35:26', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:38:37', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:38:58', '1', 'BXC270014209713', NULL),
('2024-11-20', '15:39:53', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:55:27', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:56:16', '1', 'BXC270014209713', NULL),
('2024-11-20', '18:14:44', '1', 'BXC270014209315', NULL),
('2024-11-20', '18:39:22', '1', 'BXC270014209713', NULL),
('2024-11-20', '18:40:14', '2', 'BXC270014209713', NULL),
('2024-11-20', '18:45:16', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:40:30', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:41:09', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:46:43', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:52:14', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:56:20', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:57:31', '2', 'BXC270014209713', NULL),
('2024-11-21', '01:09:27', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:09:40', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:09:48', '2', 'BXC270014209713', NULL),
('2024-11-21', '01:11:02', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:11:10', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:21:06', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:21:14', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:48:12', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:48:52', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:49:56', '3', 'BXC270014209713', NULL),
('2024-11-21', '19:50:18', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '19:50:45', '3', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '19:54:58', '3', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '19:56:29', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '19:56:52', '2', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '19:57:08', '3', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:13:02', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:14:07', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:15:10', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:16:52', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:17:20', '2', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:28:01', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:29:50', '2', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:30:29', '2', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:30:41', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '20:31:07', '3', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '21:01:47', '1', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '21:02:50', '2', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '21:03:10', '3', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '21:03:51', '3', 'DESKTOP-RBRCJED', NULL),
('2024-11-21', '21:04:15', '4', 'DESKTOP-RBRCJED', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `Id` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Estado` int(11) NOT NULL,
  `Precio` double NOT NULL,
  `Cliente` int(11) NOT NULL,
  `Repartidor` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`Id`, `Fecha`, `Hora`, `Estado`, `Precio`, `Cliente`, `Repartidor`) VALUES
(5, '2024-11-19', '23:33:43', 3, 640, 10, '3'),
(6, '2024-11-20', '15:39:48', 3, 1070, 11, '3'),
(7, '2024-11-20', '18:15:23', 3, 1000, 12, '3'),
(8, '2024-11-20', '18:40:08', 3, 1070, 13, '3'),
(9, '2024-11-21', '19:50:33', 3, 500, 14, '3'),
(10, '2024-11-21', '19:56:45', 3, 70, 15, '3'),
(11, '2024-11-21', '20:17:08', 2, 0, 16, NULL),
(12, '2024-11-21', '20:29:02', 3, 1070, 17, '3'),
(13, '2024-11-21', '20:29:42', 2, 570, 18, NULL),
(14, '2024-11-21', '20:30:59', 3, 570, 19, '3'),
(15, '2024-11-21', '21:02:28', 1, 1500, 20, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidosproductos`
--

CREATE TABLE `pedidosproductos` (
  `Pedido` int(11) NOT NULL,
  `Producto` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pedidosproductos`
--

INSERT INTO `pedidosproductos` (`Pedido`, `Producto`, `Cantidad`) VALUES
(5, 1, 1),
(5, 5, 1),
(5, 6, 2),
(6, 1, 1),
(6, 4, 1),
(6, 5, 2),
(7, 1, 2),
(7, 3, 1),
(8, 1, 1),
(8, 3, 1),
(8, 5, 2),
(9, 1, 1),
(10, 5, 1),
(12, 1, 1),
(12, 3, 1),
(12, 5, 2),
(13, 4, 2),
(13, 5, 1),
(14, 1, 1),
(14, 5, 2),
(15, 1, 1),
(15, 2, 1),
(15, 4, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Precio` double NOT NULL,
  `Tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`Id`, `Nombre`, `Precio`, `Tipo`) VALUES
(1, 'Queso 30cm', 500, 1),
(2, 'Pepperoni 30cm', 500, 1),
(3, '4 Quesos 30cm', 500, 1),
(4, 'Hawaiana 30cm', 500, 1),
(5, 'Coca-Cola 500ml', 70, 2),
(6, 'Sprite 500ml', 70, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tickets`
--

CREATE TABLE `tickets` (
  `Id` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Pedido` int(11) NOT NULL,
  `Pago` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tickets`
--

INSERT INTO `tickets` (`Id`, `Fecha`, `Hora`, `Pedido`, `Pago`) VALUES
(1, '2024-11-19', '23:33:43', 5, 0),
(2, '2024-11-20', '15:39:48', 6, 0),
(3, '2024-11-20', '18:15:23', 7, 0),
(4, '2024-11-20', '18:40:08', 8, 0),
(5, '2024-11-21', '19:50:33', 9, 0),
(6, '2024-11-21', '19:56:45', 10, 0),
(7, '2024-11-21', '20:17:08', 11, 0),
(8, '2024-11-21', '20:29:02', 12, 0),
(9, '2024-11-21', '20:29:42', 13, 0),
(10, '2024-11-21', '20:30:59', 14, 0),
(11, '2024-11-21', '21:02:28', 15, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`Cedula`);

--
-- Indices de la tabla `funcionariospedidos`
--
ALTER TABLE `funcionariospedidos`
  ADD PRIMARY KEY (`Funcionario`,`Pedido`),
  ADD KEY `Pedido` (`Pedido`);

--
-- Indices de la tabla `funcionariostelefonos`
--
ALTER TABLE `funcionariostelefonos`
  ADD PRIMARY KEY (`Funcionario`,`Telefono`);

--
-- Indices de la tabla `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`Fecha`,`Hora`,`Funcionario`),
  ADD KEY `Funcionario` (`Funcionario`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Cliente` (`Cliente`),
  ADD KEY `Repartidor` (`Repartidor`);

--
-- Indices de la tabla `pedidosproductos`
--
ALTER TABLE `pedidosproductos`
  ADD PRIMARY KEY (`Pedido`,`Producto`),
  ADD KEY `Producto` (`Producto`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Pedido` (`Pedido`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tickets`
--
ALTER TABLE `tickets`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `funcionariospedidos`
--
ALTER TABLE `funcionariospedidos`
  ADD CONSTRAINT `funcionariospedidos_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`),
  ADD CONSTRAINT `funcionariospedidos_ibfk_2` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`);

--
-- Filtros para la tabla `funcionariostelefonos`
--
ALTER TABLE `funcionariostelefonos`
  ADD CONSTRAINT `funcionariostelefonos_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`);

--
-- Filtros para la tabla `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `logs_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`);

--
-- Filtros para la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `Repartidor` FOREIGN KEY (`Repartidor`) REFERENCES `funcionarios` (`Cedula`),
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`Cliente`) REFERENCES `clientes` (`Id`);

--
-- Filtros para la tabla `pedidosproductos`
--
ALTER TABLE `pedidosproductos`
  ADD CONSTRAINT `pedidosproductos_ibfk_1` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`),
  ADD CONSTRAINT `pedidosproductos_ibfk_2` FOREIGN KEY (`Producto`) REFERENCES `productos` (`Id`);

--
-- Filtros para la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
