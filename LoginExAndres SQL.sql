USE [LoginExAndres]
GO
/****** Object:  Table [dbo].[Accesorio]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accesorio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asignacion]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Posicion] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Localidad] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipo]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[MarcaId] [int] NOT NULL,
	[Procesador] [varchar](50) NOT NULL,
	[Memoria] [varchar](50) NOT NULL,
	[Disco] [varchar](50) NOT NULL,
	[AsignacionId] [int] NOT NULL,
	[Serial] [varchar](50) NOT NULL,
	[ModeloId] [int] NOT NULL,
	[MonitorId] [int] NOT NULL,
	[AccesorioId] [int] NOT NULL,
	[Fcreacion] [datetime] NULL,
	[Factualizacion] [datetime] NULL,
	[Fdespacho] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[modulo]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modulo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monitor]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monitor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Serial] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Tamaño] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolAdmin]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolAdmin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdConsulta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolConsulta]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolConsulta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[IdModulo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalidaEquipo]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalidaEquipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NULL,
	[Serial] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[Empleado] [varchar](50) NULL,
	[FechaDespacho] [datetime] NULL,
	[EquipoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 11/25/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[IdRol] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accesorio] ON 

INSERT [dbo].[Accesorio] ([Id], [Nombre]) VALUES (2, N'teclado')
INSERT [dbo].[Accesorio] ([Id], [Nombre]) VALUES (6, N'Mouse')
INSERT [dbo].[Accesorio] ([Id], [Nombre]) VALUES (9, N'Teclado y raton')
INSERT [dbo].[Accesorio] ([Id], [Nombre]) VALUES (12, N'Teclado, mouse, audifonos')
INSERT [dbo].[Accesorio] ([Id], [Nombre]) VALUES (13, N'Teclado, mouse, bocina')
INSERT [dbo].[Accesorio] ([Id], [Nombre]) VALUES (19, N'Bocinas')
SET IDENTITY_INSERT [dbo].[Accesorio] OFF
GO
SET IDENTITY_INSERT [dbo].[Asignacion] ON 

INSERT [dbo].[Asignacion] ([Id], [Nombre]) VALUES (1, N'Fijo')
INSERT [dbo].[Asignacion] ([Id], [Nombre]) VALUES (2, N'Prestamo')
SET IDENTITY_INSERT [dbo].[Asignacion] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Id], [Nombre], [Codigo], [Posicion], [Direccion], [Localidad]) VALUES (5, N'Eduardo Ramirez', 1212, N'gerente', N'Comercial', N'las americas')
INSERT [dbo].[Empleado] ([Id], [Nombre], [Codigo], [Posicion], [Direccion], [Localidad]) VALUES (8, N'Nixon Segura', 7186, N'Desarrollador Senior', N'Tecnologia', N'Megacentro')
INSERT [dbo].[Empleado] ([Id], [Nombre], [Codigo], [Posicion], [Direccion], [Localidad]) VALUES (9, N'andres Francisco', 7186, N'Desarrollador junior', N'Tecnologia', N'Megacentro')
INSERT [dbo].[Empleado] ([Id], [Nombre], [Codigo], [Posicion], [Direccion], [Localidad]) VALUES (10, N'Roberto Orlando', 4588, N'Analista base de datos', N'Distribucion', N'Sabana larga')
INSERT [dbo].[Empleado] ([Id], [Nombre], [Codigo], [Posicion], [Direccion], [Localidad]) VALUES (12, N'Maria Gutierrez', 2156, N'Reclutadora', N'RR.HH', N'Megacentro')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipo] ON 

INSERT [dbo].[Equipo] ([Id], [EmpleadoId], [MarcaId], [Procesador], [Memoria], [Disco], [AsignacionId], [Serial], [ModeloId], [MonitorId], [AccesorioId], [Fcreacion], [Factualizacion], [Fdespacho]) VALUES (7, 5, 7, N'intel dual core', N'8 gb', N'500 gb', 2, N'1009965', 16, 6, 6, CAST(N'2021-11-10T00:00:00.000' AS DateTime), CAST(N'2021-11-09T00:00:00.000' AS DateTime), CAST(N'2021-11-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Equipo] ([Id], [EmpleadoId], [MarcaId], [Procesador], [Memoria], [Disco], [AsignacionId], [Serial], [ModeloId], [MonitorId], [AccesorioId], [Fcreacion], [Factualizacion], [Fdespacho]) VALUES (11, 10, 12, N'intel dual core', N'32 gb', N'2 tb', 1, N'2343233', 20, 8, 12, CAST(N'2021-11-10T00:00:00.000' AS DateTime), NULL, CAST(N'2021-11-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Equipo] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([Id], [Nombre]) VALUES (7, N'Samsung')
INSERT [dbo].[Marca] ([Id], [Nombre]) VALUES (12, N'LG')
INSERT [dbo].[Marca] ([Id], [Nombre]) VALUES (13, N'MSI')
INSERT [dbo].[Marca] ([Id], [Nombre]) VALUES (15, N'Dell')
INSERT [dbo].[Marca] ([Id], [Nombre]) VALUES (17, N'HP')
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelo] ON 

INSERT [dbo].[Modelo] ([Id], [Nombre]) VALUES (16, N'Optiplex 7040')
INSERT [dbo].[Modelo] ([Id], [Nombre]) VALUES (18, N'Optiplex 3070')
INSERT [dbo].[Modelo] ([Id], [Nombre]) VALUES (19, N'Optiplex 3090')
INSERT [dbo].[Modelo] ([Id], [Nombre]) VALUES (20, N'GR-274')
INSERT [dbo].[Modelo] ([Id], [Nombre]) VALUES (21, N'Serie 8')
INSERT [dbo].[Modelo] ([Id], [Nombre]) VALUES (22, N'Serie 7')
INSERT [dbo].[Modelo] ([Id], [Nombre]) VALUES (23, N'Alienware')
SET IDENTITY_INSERT [dbo].[Modelo] OFF
GO
SET IDENTITY_INSERT [dbo].[modulo] ON 

INSERT [dbo].[modulo] ([Id], [Nombre]) VALUES (1, N'usuarios')
INSERT [dbo].[modulo] ([Id], [Nombre]) VALUES (2, N'roles')
SET IDENTITY_INSERT [dbo].[modulo] OFF
GO
SET IDENTITY_INSERT [dbo].[Monitor] ON 

INSERT [dbo].[Monitor] ([Id], [Marca], [Serial], [Modelo], [Tamaño], [Cantidad]) VALUES (2, N'LG', N'1561A125', N'optiplex', N'32 pulgadas', 2)
INSERT [dbo].[Monitor] ([Id], [Marca], [Serial], [Modelo], [Tamaño], [Cantidad]) VALUES (6, N'Samsung', N'22322a555', N'serie 7', N'24 pulgadas', 1)
INSERT [dbo].[Monitor] ([Id], [Marca], [Serial], [Modelo], [Tamaño], [Cantidad]) VALUES (8, N'MSI', N'23321A21', N'GR-274', N'27 pulgadas', 2)
INSERT [dbo].[Monitor] ([Id], [Marca], [Serial], [Modelo], [Tamaño], [Cantidad]) VALUES (9, N'Dell', N'343341', N'Alienware', N'32 pulgadas', 1)
SET IDENTITY_INSERT [dbo].[Monitor] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([Id], [Nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Rol] ([Id], [Nombre]) VALUES (2, N'Consultante')
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[RolAdmin] ON 

INSERT [dbo].[RolAdmin] ([Id], [IdRol], [IdConsulta]) VALUES (4, 1, 1)
INSERT [dbo].[RolAdmin] ([Id], [IdRol], [IdConsulta]) VALUES (5, 1, 2)
INSERT [dbo].[RolAdmin] ([Id], [IdRol], [IdConsulta]) VALUES (6, 1, 3)
INSERT [dbo].[RolAdmin] ([Id], [IdRol], [IdConsulta]) VALUES (7, 1, 4)
INSERT [dbo].[RolAdmin] ([Id], [IdRol], [IdConsulta]) VALUES (8, 1, 5)
INSERT [dbo].[RolAdmin] ([Id], [IdRol], [IdConsulta]) VALUES (13, 2, 5)
INSERT [dbo].[RolAdmin] ([Id], [IdRol], [IdConsulta]) VALUES (14, 2, 1)
SET IDENTITY_INSERT [dbo].[RolAdmin] OFF
GO
SET IDENTITY_INSERT [dbo].[RolConsulta] ON 

INSERT [dbo].[RolConsulta] ([Id], [Nombre], [IdModulo]) VALUES (1, N'agregar', 1)
INSERT [dbo].[RolConsulta] ([Id], [Nombre], [IdModulo]) VALUES (2, N'editar', 1)
INSERT [dbo].[RolConsulta] ([Id], [Nombre], [IdModulo]) VALUES (3, N'eliminar', 1)
INSERT [dbo].[RolConsulta] ([Id], [Nombre], [IdModulo]) VALUES (4, N'ver', 1)
INSERT [dbo].[RolConsulta] ([Id], [Nombre], [IdModulo]) VALUES (5, N'ver', 2)
SET IDENTITY_INSERT [dbo].[RolConsulta] OFF
GO
SET IDENTITY_INSERT [dbo].[SalidaEquipo] ON 

INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (7, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo', CAST(N'2021-11-11T16:38:49.857' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (8, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo', CAST(N'2021-11-11T16:39:32.420' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (9, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo', CAST(N'2021-11-11T16:40:54.753' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (10, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo', CAST(N'2021-11-11T16:41:01.837' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (11, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo Ramirez', CAST(N'2021-11-11T16:52:10.797' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (12, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo Ramirez', CAST(N'2021-11-11T16:53:20.090' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (13, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo Ramirez', CAST(N'2021-11-11T16:54:32.133' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (14, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo Ramirez', CAST(N'2021-11-11T16:56:45.947' AS DateTime), 7)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (15, N'LG', N'2343233', N'GR-274', N'Roberto Orlando', CAST(N'2021-11-12T08:06:26.680' AS DateTime), 11)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (16, N'LG', N'2343233', N'GR-274', N'Roberto Orlando', CAST(N'2021-11-12T08:12:36.883' AS DateTime), 11)
INSERT [dbo].[SalidaEquipo] ([Id], [Marca], [Serial], [Modelo], [Empleado], [FechaDespacho], [EquipoId]) VALUES (17, N'Samsung', N'1009965', N'Optiplex 7040', N'Eduardo Ramirez', CAST(N'2021-11-12T08:58:54.710' AS DateTime), 7)
SET IDENTITY_INSERT [dbo].[SalidaEquipo] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([Id], [Usuario], [email], [password], [IdRol]) VALUES (13, N'admin', N'administall@hotmail.com', N'11', 1)
INSERT [dbo].[usuario] ([Id], [Usuario], [email], [password], [IdRol]) VALUES (16, N'Consultor', N'Consulta@hotmail.com', N'11', 2)
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD  CONSTRAINT [FK__Equipo__Accesori__0B91BA14] FOREIGN KEY([AccesorioId])
REFERENCES [dbo].[Accesorio] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Equipo] CHECK CONSTRAINT [FK__Equipo__Accesori__0B91BA14]
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD  CONSTRAINT [FK__Equipo__Asignaci__06CD04F7] FOREIGN KEY([AsignacionId])
REFERENCES [dbo].[Asignacion] ([Id])
GO
ALTER TABLE [dbo].[Equipo] CHECK CONSTRAINT [FK__Equipo__Asignaci__06CD04F7]
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD  CONSTRAINT [FK__Equipo__Empleado__07C12930] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleado] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Equipo] CHECK CONSTRAINT [FK__Equipo__Empleado__07C12930]
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD  CONSTRAINT [FK__Equipo__MarcaId__08B54D69] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[Marca] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Equipo] CHECK CONSTRAINT [FK__Equipo__MarcaId__08B54D69]
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD  CONSTRAINT [FK__Equipo__ModeloId__09A971A2] FOREIGN KEY([ModeloId])
REFERENCES [dbo].[Modelo] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Equipo] CHECK CONSTRAINT [FK__Equipo__ModeloId__09A971A2]
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD  CONSTRAINT [FK__Equipo__MonitorI__0A9D95DB] FOREIGN KEY([MonitorId])
REFERENCES [dbo].[Monitor] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Equipo] CHECK CONSTRAINT [FK__Equipo__MonitorI__0A9D95DB]
GO
ALTER TABLE [dbo].[RolAdmin]  WITH CHECK ADD FOREIGN KEY([IdConsulta])
REFERENCES [dbo].[RolConsulta] ([Id])
GO
ALTER TABLE [dbo].[RolAdmin]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[RolConsulta]  WITH CHECK ADD FOREIGN KEY([IdModulo])
REFERENCES [dbo].[modulo] ([Id])
GO
ALTER TABLE [dbo].[SalidaEquipo]  WITH CHECK ADD  CONSTRAINT [FK__SalidaEqu__Equip__1AD3FDA4] FOREIGN KEY([EquipoId])
REFERENCES [dbo].[Equipo] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SalidaEquipo] CHECK CONSTRAINT [FK__SalidaEqu__Equip__1AD3FDA4]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([Id])
GO
