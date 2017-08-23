-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-08-2017 a las 22:58:23
-- Versión del servidor: 5.7.14
-- Versión de PHP: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inventario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clasificacion_inventario`
--

CREATE TABLE `clasificacion_inventario` (
  `id_clasi_inv_pk` int(11) NOT NULL,
  `nombre_clasi` varchar(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clasificacion_inventario`
--

INSERT INTO `clasificacion_inventario` (`id_clasi_inv_pk`, `nombre_clasi`) VALUES
(1, 'Plataforma TI'),
(2, 'Seguridad Informatica'),
(3, 'Gestion de Redes');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cluster`
--

CREATE TABLE `cluster` (
  `id_cluster_pk` int(11) NOT NULL,
  `nombre_cluster` varchar(40) DEFAULT NULL,
  `estado` varchar(14) NOT NULL DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cluster`
--

INSERT INTO `cluster` (`id_cluster_pk`, `nombre_cluster`, `estado`) VALUES
(1, 'Cluster 1 ', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dato_general`
--

CREATE TABLE `dato_general` (
  `id_dato_hw_pk` int(11) NOT NULL,
  `nombre_dato` varchar(40) DEFAULT NULL,
  `estado` varchar(15) DEFAULT 'ACTIVO',
  `id_clasi_inv_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `dato_general`
--

INSERT INTO `dato_general` (`id_dato_hw_pk`, `nombre_dato`, `estado`, `id_clasi_inv_pk`) VALUES
(1, 'Hostname', 'ACTIVO', 1),
(2, 'IP1', 'ACTIVO', 1),
(3, 'IP2', 'ACTIVO', 1),
(4, 'Hostname', 'ACTIVO', 2),
(5, 'IP1', 'ACTIVO', 2),
(6, 'IP2', 'ACTIVO', 2),
(7, 'Version ios', 'ACTIVO', 3),
(8, 'IP', 'ACTIVO', 3),
(9, 'Serial Number', 'ACTIVO', 3),
(10, 'Funcion', 'ACTIVO', 3),
(11, 'Nombre', 'ACTIVO', 3),
(12, 'Nuevo', 'ACTIVO', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_general`
--

CREATE TABLE `detalle_general` (
  `id_detalle_hw_pk` int(11) NOT NULL,
  `descipcion_det` varchar(75) DEFAULT NULL,
  `id_dato_hw_pk` int(11) DEFAULT NULL,
  `id_gestion_redes_pk` int(11) DEFAULT NULL,
  `id_infra_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dominio`
--

CREATE TABLE `dominio` (
  `id_dominio_pk` int(11) NOT NULL,
  `nombre_dominio` varchar(40) DEFAULT NULL,
  `estado` varchar(14) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gabinete`
--

CREATE TABLE `gabinete` (
  `id_gabinete_pk` int(11) NOT NULL,
  `nombre_gabinete` varchar(34) DEFAULT NULL,
  `estado` varchar(14) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `gabinete`
--

INSERT INTO `gabinete` (`id_gabinete_pk`, `nombre_gabinete`, `estado`) VALUES
(1, 'GA01', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `garantia`
--

CREATE TABLE `garantia` (
  `id_garantia_pk` int(11) NOT NULL,
  `fecha_garantia` date DEFAULT NULL,
  `descripcion_garantia` varchar(50) DEFAULT NULL,
  `id_gestion_redes_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gestion_redes`
--

CREATE TABLE `gestion_redes` (
  `id_gestion_redes_pk` int(11) NOT NULL,
  `nombre_gest` varchar(50) NOT NULL,
  `fecha_inicio_garantia` date DEFAULT NULL,
  `estado` varchar(15) NOT NULL,
  `id_modelo_pk` int(11) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL,
  `id_ubicacion_pk` int(11) DEFAULT NULL,
  `id_prov_mante_pk` int(11) DEFAULT NULL,
  `id_tipo_equipo_pk` int(11) DEFAULT NULL,
  `id_clasi_inv_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `infraestructura`
--

CREATE TABLE `infraestructura` (
  `id_infra_pk` int(11) NOT NULL,
  `nombre_infra` varchar(50) NOT NULL,
  `estado` varchar(14) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL,
  `id_modelo_pk` int(11) DEFAULT NULL,
  `id_so_pk` int(11) DEFAULT NULL,
  `id_tipo_pk` int(11) DEFAULT NULL,
  `id_prov_mante_pk` int(11) DEFAULT NULL,
  `id_gabinete_pk` int(11) DEFAULT NULL,
  `id_dominio_pk` int(11) DEFAULT NULL,
  `id_rol_pk` int(11) DEFAULT NULL,
  `id_cluster_pk` int(11) DEFAULT NULL,
  `id_clasi_inv_pk` int(11) DEFAULT NULL,
  `id_ubicacion_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `id_marca_pk` int(11) NOT NULL,
  `nombre_marca` varchar(50) DEFAULT NULL,
  `estado` varchar(25) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id_marca_pk`, `nombre_marca`, `estado`) VALUES
(1, 'Dell', 'ACTIVO'),
(2, 'HP', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modelo`
--

CREATE TABLE `modelo` (
  `id_modelo_pk` int(11) NOT NULL,
  `nombre_modelo` varchar(35) DEFAULT NULL,
  `estado` varchar(15) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modelo`
--

INSERT INTO `modelo` (`id_modelo_pk`, `nombre_modelo`, `estado`) VALUES
(1, 'CIsco', 'ACTIVO'),
(2, 'SG 300-28', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor_mantenimiento`
--

CREATE TABLE `proveedor_mantenimiento` (
  `id_prov_mante_pk` int(11) NOT NULL,
  `nombre_prov_mant` varchar(50) DEFAULT NULL,
  `estado` varchar(14) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor_mantenimiento`
--

INSERT INTO `proveedor_mantenimiento` (`id_prov_mante_pk`, `nombre_prov_mant`, `estado`) VALUES
(1, 'N/A ', 'ACTIVO'),
(2, 'SPC', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rol`
--

CREATE TABLE `rol` (
  `id_rol_pk` int(11) NOT NULL,
  `nombre_rol` varchar(40) DEFAULT NULL,
  `estado` varchar(14) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `rol`
--

INSERT INTO `rol` (`id_rol_pk`, `nombre_rol`, `estado`) VALUES
(1, 'Rol 1', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sistema_operativo`
--

CREATE TABLE `sistema_operativo` (
  `id_so_pk` int(11) NOT NULL,
  `nombre_so` varchar(50) DEFAULT NULL,
  `version_so` varchar(10) DEFAULT NULL,
  `estado` varchar(25) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo`
--

CREATE TABLE `tipo` (
  `id_tipo_pk` int(11) NOT NULL,
  `nombre_tipo` varchar(10) DEFAULT NULL,
  `estado` varchar(14) DEFAULT 'ACTIVO',
  `id_clasi_inv_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_equipo`
--

CREATE TABLE `tipo_equipo` (
  `id_tipo_equipo_pk` int(11) NOT NULL,
  `nombre_tipo` varchar(50) DEFAULT NULL,
  `detalle` varchar(40) DEFAULT NULL,
  `estado` varchar(14) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_equipo`
--

INSERT INTO `tipo_equipo` (`id_tipo_equipo_pk`, `nombre_tipo`, `detalle`, `estado`) VALUES
(1, 'Switch', '--', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ubicacion`
--

CREATE TABLE `ubicacion` (
  `id_ubicacion_pk` int(11) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `detalle` varchar(40) DEFAULT NULL,
  `estado` varchar(14) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ubicacion`
--

INSERT INTO `ubicacion` (`id_ubicacion_pk`, `nombre`, `detalle`, `estado`) VALUES
(1, 'Torre 1', 'Nivel 8 ', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vlan`
--

CREATE TABLE `vlan` (
  `id_vlan_pk` int(11) NOT NULL,
  `vlan` varchar(30) DEFAULT NULL,
  `ubicacion` varchar(50) DEFAULT NULL,
  `nombre_vlan` varchar(50) DEFAULT NULL,
  `segmento` varchar(40) DEFAULT NULL,
  `mascara` varchar(40) DEFAULT NULL,
  `puerta_enlace` varchar(40) DEFAULT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `estado` varchar(50) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clasificacion_inventario`
--
ALTER TABLE `clasificacion_inventario`
  ADD PRIMARY KEY (`id_clasi_inv_pk`);

--
-- Indices de la tabla `cluster`
--
ALTER TABLE `cluster`
  ADD PRIMARY KEY (`id_cluster_pk`);

--
-- Indices de la tabla `dato_general`
--
ALTER TABLE `dato_general`
  ADD PRIMARY KEY (`id_dato_hw_pk`),
  ADD KEY `Refclasificacion_inventario22` (`id_clasi_inv_pk`);

--
-- Indices de la tabla `detalle_general`
--
ALTER TABLE `detalle_general`
  ADD PRIMARY KEY (`id_detalle_hw_pk`),
  ADD KEY `Refdato_general23` (`id_dato_hw_pk`),
  ADD KEY `Refgestion_redes32` (`id_gestion_redes_pk`),
  ADD KEY `Refinfraestructura33` (`id_infra_pk`);

--
-- Indices de la tabla `dominio`
--
ALTER TABLE `dominio`
  ADD PRIMARY KEY (`id_dominio_pk`);

--
-- Indices de la tabla `gabinete`
--
ALTER TABLE `gabinete`
  ADD PRIMARY KEY (`id_gabinete_pk`);

--
-- Indices de la tabla `garantia`
--
ALTER TABLE `garantia`
  ADD PRIMARY KEY (`id_garantia_pk`),
  ADD KEY `Refgestion_redes2` (`id_gestion_redes_pk`);

--
-- Indices de la tabla `gestion_redes`
--
ALTER TABLE `gestion_redes`
  ADD PRIMARY KEY (`id_gestion_redes_pk`),
  ADD KEY `RefModelo3` (`id_modelo_pk`),
  ADD KEY `RefMarca4` (`id_marca_pk`),
  ADD KEY `Refubicacion9` (`id_ubicacion_pk`),
  ADD KEY `Refproveedor_mantenimiento17` (`id_prov_mante_pk`),
  ADD KEY `Reftipo_equipo21` (`id_tipo_equipo_pk`),
  ADD KEY `Refclasificacion_inventario29` (`id_clasi_inv_pk`);

--
-- Indices de la tabla `infraestructura`
--
ALTER TABLE `infraestructura`
  ADD PRIMARY KEY (`id_infra_pk`),
  ADD KEY `RefMarca5` (`id_marca_pk`),
  ADD KEY `RefModelo6` (`id_modelo_pk`),
  ADD KEY `RefSistema_operativo7` (`id_so_pk`),
  ADD KEY `Reftipo10` (`id_tipo_pk`),
  ADD KEY `Refproveedor_mantenimiento11` (`id_prov_mante_pk`),
  ADD KEY `RefGabinete12` (`id_gabinete_pk`),
  ADD KEY `RefDominio13` (`id_dominio_pk`),
  ADD KEY `RefRol14` (`id_rol_pk`),
  ADD KEY `Refcluster15` (`id_cluster_pk`),
  ADD KEY `Refclasificacion_inventario30` (`id_clasi_inv_pk`),
  ADD KEY `Refubicacion35` (`id_ubicacion_pk`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca_pk`);

--
-- Indices de la tabla `modelo`
--
ALTER TABLE `modelo`
  ADD PRIMARY KEY (`id_modelo_pk`);

--
-- Indices de la tabla `proveedor_mantenimiento`
--
ALTER TABLE `proveedor_mantenimiento`
  ADD PRIMARY KEY (`id_prov_mante_pk`);

--
-- Indices de la tabla `rol`
--
ALTER TABLE `rol`
  ADD PRIMARY KEY (`id_rol_pk`);

--
-- Indices de la tabla `sistema_operativo`
--
ALTER TABLE `sistema_operativo`
  ADD PRIMARY KEY (`id_so_pk`);

--
-- Indices de la tabla `tipo`
--
ALTER TABLE `tipo`
  ADD PRIMARY KEY (`id_tipo_pk`),
  ADD KEY `Refclasificacion_inventario34` (`id_clasi_inv_pk`);

--
-- Indices de la tabla `tipo_equipo`
--
ALTER TABLE `tipo_equipo`
  ADD PRIMARY KEY (`id_tipo_equipo_pk`);

--
-- Indices de la tabla `ubicacion`
--
ALTER TABLE `ubicacion`
  ADD PRIMARY KEY (`id_ubicacion_pk`);

--
-- Indices de la tabla `vlan`
--
ALTER TABLE `vlan`
  ADD PRIMARY KEY (`id_vlan_pk`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clasificacion_inventario`
--
ALTER TABLE `clasificacion_inventario`
  MODIFY `id_clasi_inv_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `cluster`
--
ALTER TABLE `cluster`
  MODIFY `id_cluster_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `dato_general`
--
ALTER TABLE `dato_general`
  MODIFY `id_dato_hw_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT de la tabla `detalle_general`
--
ALTER TABLE `detalle_general`
  MODIFY `id_detalle_hw_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `dominio`
--
ALTER TABLE `dominio`
  MODIFY `id_dominio_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `gabinete`
--
ALTER TABLE `gabinete`
  MODIFY `id_gabinete_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `gestion_redes`
--
ALTER TABLE `gestion_redes`
  MODIFY `id_gestion_redes_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `infraestructura`
--
ALTER TABLE `infraestructura`
  MODIFY `id_infra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `modelo`
--
ALTER TABLE `modelo`
  MODIFY `id_modelo_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `proveedor_mantenimiento`
--
ALTER TABLE `proveedor_mantenimiento`
  MODIFY `id_prov_mante_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `rol`
--
ALTER TABLE `rol`
  MODIFY `id_rol_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `sistema_operativo`
--
ALTER TABLE `sistema_operativo`
  MODIFY `id_so_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipo`
--
ALTER TABLE `tipo`
  MODIFY `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `tipo_equipo`
--
ALTER TABLE `tipo_equipo`
  MODIFY `id_tipo_equipo_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `ubicacion`
--
ALTER TABLE `ubicacion`
  MODIFY `id_ubicacion_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `vlan`
--
ALTER TABLE `vlan`
  MODIFY `id_vlan_pk` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
