--Copy all users from Ria membership to msm membership
DELETE [MSMMembership].[dbo].[AspNetUsers]
DELETE [MSMMembership].[dbo].[AspNetRoles]
DELETE [MSMMembership].[dbo].[AspNetUserRoles]

INSERT INTO [MSMMembership].[dbo].[AspNetUsers]
    ([Id]
    ,[AccessFailedCount]
	,[CreatedDate]
    ,[EmailConfirmed]
	,[Locked]
    ,[LockoutEnabled]
    ,[NormalizedUserName]
    ,[PasswordHash]
    ,[PhoneNumberConfirmed]
	,[SecurityStamp]
    ,[TwoFactorEnabled]
    ,[UserName])
(SELECT UserId,0,GETDATE(),
	 0,0,1,UserName,
	 'AQAAAAEAACcQAAAAEP0IRqdzG/j6UZMQ4kwYyxgTlFR2v0hLTCRCgitN++QoqKrxcuaOwoVprQMdZOhNjg==',
	 0,'718b3fbd-dbb5-45e4-8808-609cd1e7c273',0,UserName
	 FROM [RIAMembership].[dbo].[aspnet_Users])


INSERT INTO [MSMMembership].[dbo].[AspNetRoles]([Id], [Description], [Name],[NormalizedName])
(SELECT RoleId,Description,RoleName,RoleName FROM [RIAMembership].[dbo].[aspnet_Roles])

INSERT INTO [MSMMembership].[dbo].[AspNetUserRoles]([UserId],[RoleId])
(SELECT [UserId],[RoleId] FROM [RIAMembership].[dbo].[aspnet_UsersInRoles])