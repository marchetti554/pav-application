USE [pav-db]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [bigint] IDENTITY(1,1) NOT NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[razon_social] [varchar](50) NULL,
	[estaEliminado] [bit] NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_orden]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_orden](
	[id_detalle] [bigint] IDENTITY(1,1) NOT NULL,
	[id_orden_trabajo] [bigint] NOT NULL,
	[descripcion_actividad] [varchar](255) NULL,
	[costo_adicional] [float] NULL,
	[duracion_calibracion] [float] NULL,
	[duracion_trabajo] [float] NULL,
	[id_maquina] [bigint] NOT NULL,
	[precio_hora] [float] NULL,
	[precio_hora_calibracion] [float] NULL,
	[duracion_real_trabajo] [float] NULL,
	[estado] [varchar](50) NULL,
	[legajo_empleado] [bigint] NULL,
	[fecha_hora_inicio] [datetime] NULL,
 CONSTRAINT [PK_detalle_cotizacion] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC,
	[id_orden_trabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[legajo_empleado] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[email] [varchar](80) NULL,
	[telefono] [varchar](50) NULL,
	[domicilio] [varchar](100) NULL,
	[estaEliminado] [bit] NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[legajo_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[id_estado] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[maquinas]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[maquinas](
	[id_maquina] [bigint] NOT NULL,
	[nombre_maquina] [varchar](50) NOT NULL,
	[descripcion_maquina] [varchar](50) NULL,
	[id_tipo_maquina] [bigint] NULL,
	[estaEliminado] [int] NULL,
 CONSTRAINT [PK_maquinas] PRIMARY KEY CLUSTERED 
(
	[id_maquina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orden_trabajo]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orden_trabajo](
	[id_orden_trabajo] [bigint] IDENTITY(1,1) NOT NULL,
	[observaciones] [varchar](100) NULL,
	[id_estado] [int] NULL,
	[precio_total] [float] NULL,
	[precio_hora_trabajo] [float] NULL,
	[precio_hora_calibracion] [float] NULL,
	[fecha_estimada_entrega] [date] NULL,
	[cantidad_piezas] [bigint] NULL,
	[dni_responsable_cliente] [varchar](50) NULL,
	[descripcion_pieza] [varchar](255) NULL,
	[tiempo_total_estimado] [float] NULL,
	[tiempo_total_real] [float] NULL,
 CONSTRAINT [PK_Cotizaciones] PRIMARY KEY CLUSTERED 
(
	[id_orden_trabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[responsable_empresa]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[responsable_empresa](
	[dni] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[id_cliente] [bigint] NOT NULL,
	[estaEliminado] [bit] NULL,
 CONSTRAINT [PK_responsable_empresa] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipos_maquina]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipos_maquina](
	[id_tipo_maquina] [bigint] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_tipos_maquina] PRIMARY KEY CLUSTERED 
(
	[id_tipo_maquina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 12/11/2019 03:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[nombre_usuario] [varchar](14) NULL,
	[password] [varchar](20) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF_clientes_estaEliminado]  DEFAULT ((0)) FOR [estaEliminado]
GO
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF_empleados_estaEliminado]  DEFAULT ((0)) FOR [estaEliminado]
GO
ALTER TABLE [dbo].[maquinas] ADD  CONSTRAINT [DF_maquinas_estaEliminado]  DEFAULT ((0)) FOR [estaEliminado]
GO
ALTER TABLE [dbo].[responsable_empresa] ADD  CONSTRAINT [DF_responsable_empresa_estaEliminado]  DEFAULT ((0)) FOR [estaEliminado]
GO
ALTER TABLE [dbo].[detalle_orden]  WITH CHECK ADD  CONSTRAINT [FK_detalle_cotizacion_maquinas] FOREIGN KEY([id_maquina])
REFERENCES [dbo].[maquinas] ([id_maquina])
GO
ALTER TABLE [dbo].[detalle_orden] CHECK CONSTRAINT [FK_detalle_cotizacion_maquinas]
GO
ALTER TABLE [dbo].[detalle_orden]  WITH CHECK ADD  CONSTRAINT [FK_detalle_orden_empleados] FOREIGN KEY([legajo_empleado])
REFERENCES [dbo].[empleados] ([legajo_empleado])
GO
ALTER TABLE [dbo].[detalle_orden] CHECK CONSTRAINT [FK_detalle_orden_empleados]
GO
ALTER TABLE [dbo].[detalle_orden]  WITH CHECK ADD  CONSTRAINT [FK_detalle_orden_orden_trabajo] FOREIGN KEY([id_orden_trabajo])
REFERENCES [dbo].[orden_trabajo] ([id_orden_trabajo])
GO
ALTER TABLE [dbo].[detalle_orden] CHECK CONSTRAINT [FK_detalle_orden_orden_trabajo]
GO
ALTER TABLE [dbo].[estado]  WITH CHECK ADD  CONSTRAINT [FK_estado_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id_estado])
GO
ALTER TABLE [dbo].[estado] CHECK CONSTRAINT [FK_estado_estado]
GO
ALTER TABLE [dbo].[maquinas]  WITH CHECK ADD  CONSTRAINT [FK_maquinas_tipos_maquina] FOREIGN KEY([id_tipo_maquina])
REFERENCES [dbo].[tipos_maquina] ([id_tipo_maquina])
GO
ALTER TABLE [dbo].[maquinas] CHECK CONSTRAINT [FK_maquinas_tipos_maquina]
GO
ALTER TABLE [dbo].[orden_trabajo]  WITH CHECK ADD  CONSTRAINT [FK_orden_trabajo_orden_trabajo] FOREIGN KEY([id_orden_trabajo])
REFERENCES [dbo].[orden_trabajo] ([id_orden_trabajo])
GO
ALTER TABLE [dbo].[orden_trabajo] CHECK CONSTRAINT [FK_orden_trabajo_orden_trabajo]
GO
ALTER TABLE [dbo].[orden_trabajo]  WITH CHECK ADD  CONSTRAINT [FK_orden_trabajo_orden_trabajo1] FOREIGN KEY([id_orden_trabajo])
REFERENCES [dbo].[orden_trabajo] ([id_orden_trabajo])
GO
ALTER TABLE [dbo].[orden_trabajo] CHECK CONSTRAINT [FK_orden_trabajo_orden_trabajo1]
GO
ALTER TABLE [dbo].[orden_trabajo]  WITH CHECK ADD  CONSTRAINT [FK_orden_trabajo_orden_trabajo2] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id_estado])
GO
ALTER TABLE [dbo].[orden_trabajo] CHECK CONSTRAINT [FK_orden_trabajo_orden_trabajo2]
GO
ALTER TABLE [dbo].[orden_trabajo]  WITH CHECK ADD  CONSTRAINT [FK_orden_trabajo_responsable_empresa] FOREIGN KEY([dni_responsable_cliente])
REFERENCES [dbo].[responsable_empresa] ([dni])
GO
ALTER TABLE [dbo].[orden_trabajo] CHECK CONSTRAINT [FK_orden_trabajo_responsable_empresa]
GO
ALTER TABLE [dbo].[responsable_empresa]  WITH CHECK ADD  CONSTRAINT [FK_responsable_empresa_clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[responsable_empresa] CHECK CONSTRAINT [FK_responsable_empresa_clientes]
GO
ALTER TABLE [dbo].[tipos_maquina]  WITH CHECK ADD  CONSTRAINT [FK_tipos_maquina_tipos_maquina] FOREIGN KEY([id_tipo_maquina])
REFERENCES [dbo].[tipos_maquina] ([id_tipo_maquina])
GO
ALTER TABLE [dbo].[tipos_maquina] CHECK CONSTRAINT [FK_tipos_maquina_tipos_maquina]
GO
