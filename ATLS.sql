USE [master]
GO
/****** Object:  Database [ATLS]    Script Date: 13/11/2018 19:29:06 ******/
CREATE DATABASE [ATLS]

GO
USE [ATLS]

GO
CREATE TABLE [dbo].[Participantes](
	[idParticipante] [int] IDENTITY(1,1) NOT NULL,
	[idProyecto] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[administrador] [int] NOT NULL,
 CONSTRAINT [PK_UsuariosProyectos] PRIMARY KEY CLUSTERED 
(
	[idParticipante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 13/11/2018 19:29:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proyecto](
	[idProyecto] [int] IDENTITY(1,1) NOT NULL,
	[nombreProyecto] [varchar](50) NOT NULL,
	[fechaCreacion] [datetime] NOT NULL,
	[activo] [bit] NOT NULL,
	[creadoPor] [int] NOT NULL,
 CONSTRAINT [PK_Proyecto] PRIMARY KEY CLUSTERED 
(
	[idProyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 13/11/2018 19:29:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
	[alias] [varchar](50) NOT NULL,
	[clave] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

GO
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [alias], [clave]) VALUES (1, N'admin', N'admin', N'admin')
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [alias], [clave]) VALUES (2, N'palarcon', N'Pablo Alarcon', N'123456')
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [alias], [clave]) VALUES (3, N'mceballos', N'Manuel Ceballos', N'manuel')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Participantes]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosProyectos_Proyecto] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[Proyecto] ([idProyecto])
GO
ALTER TABLE [dbo].[Participantes] CHECK CONSTRAINT [FK_UsuariosProyectos_Proyecto]
GO
ALTER TABLE [dbo].[Participantes]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosProyectos_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Participantes] CHECK CONSTRAINT [FK_UsuariosProyectos_Usuario]
GO
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Usuario] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Usuario]
GO
USE [master]
GO
