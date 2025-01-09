CREATE TABLE IF NOT EXISTS TICKET
(
	ID INTEGER PRIMARY KEY,
	CODE TEXT,
	AMOUNT INTEGER,
	DATETIME TEXT,
	LV1TYPE_ID INTEGER,
	LV2TYPE_ID INTEGER,
	SUMMARY TEXT,
	DESCRIPTION TEXT,
	CREATION_TIME TEXT,
	DELETION_TIME TEXT,
	UPDATION_TIME TEXT
);

CREATE TABLE IF NOT EXISTS LINKED_TICKET
(
	ID INTEGER PRIMARY KEY,
	LOWER_TICKET_ID INTEGER,
	UPPER_TICKET_ID INTEGER,
	CREATION_TIME TEXT,
	DELETION_TIME TEXT
);

CREATE TABLE IF NOT EXISTS LV2TYPE
(
	ID INTEGER PRIMARY KEY,
	LV1TYPEID INTEGER,
	NAME TEXT,
	DESCRIPTION TEXT,
	CREATION_TIME TEXT,
	DELETION_TIME TEXT,
	UPDATION_TIME TEXT
);