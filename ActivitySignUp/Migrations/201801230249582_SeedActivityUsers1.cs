namespace ActivitySignUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedActivityUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            SET IDENTITY_INSERT [dbo].[ActivityUsers] ON
                INSERT INTO [dbo].[ActivityUsers] ([Id], [FirstName], [LastName], [ActivityType], [MobileNumber], [Comments], [Email], [CreatedDate], [UpdatedDate]) VALUES (1, N'Michael', N'Zordan', 3, N'123-456-7890', N'Basketball Player', N'mzordan@gmail.com', N'2018-01-22 00:00:00', N'2018-01-22 20:12:55')
                INSERT INTO [dbo].[ActivityUsers] ([Id], [FirstName], [LastName], [ActivityType], [MobileNumber], [Comments], [Email], [CreatedDate], [UpdatedDate]) VALUES (2, N'Leonel', N'Messi', 6, N'456-123-7890', N'Soccer Player', N'lmessi@gmail.com', N'2018-01-22 00:00:00', N'2018-01-22 20:13:05')
                INSERT INTO [dbo].[ActivityUsers] ([Id], [FirstName], [LastName], [ActivityType], [MobileNumber], [Comments], [Email], [CreatedDate], [UpdatedDate]) VALUES (3, N'Brian', N'Lara', 4, N'789-123-4560', N'Cricket Player', N'blara@gmail.com', N'2018-01-22 00:00:00', N'2018-01-22 20:13:16')
                INSERT INTO [dbo].[ActivityUsers] ([Id], [FirstName], [LastName], [ActivityType], [MobileNumber], [Comments], [Email], [CreatedDate], [UpdatedDate]) VALUES (4, N'Michael', N'Phelps', 1, N'39-288-1233', N'Best swimmer in the world.', N'mphelps@gmail.com', N'2018-01-22 19:57:48', N'2018-01-22 20:13:26')
                INSERT INTO [dbo].[ActivityUsers] ([Id], [FirstName], [LastName], [ActivityType], [MobileNumber], [Comments], [Email], [CreatedDate], [UpdatedDate]) VALUES (6, N'Christiano', N'Ronaldo', 6, N'589-658-9852', N'One of the best scorer.', N'cronaldo@gmail.com', N'2018-01-22 20:47:21', NULL)
            SET IDENTITY_INSERT [dbo].[ActivityUsers] OFF
        ");
        }
        
        public override void Down()
        {
        }
    }
}
