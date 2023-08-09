Premise: migrations are already enabled

Commands for working with migrations open Package Manager Console:
	
	- Creating a new migration:		add-migration <MigrationName>
	- Running migrations on db:		update-database
	
When the db is already created with tables & want only to update migrations:
	add-migration <MigrationName> -IgnoreChanges -Force
