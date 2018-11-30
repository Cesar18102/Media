CREATE TABLE section(
  
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    name char(30) NOT NULL,
    manager_id INTEGER
);

CREATE TABLE posts(
    
    id INTEGER PRIMARY KEY NOT NULL,
    name char(30) NOT NULL
);

CREATE TABLE worker(
  
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    name char(20) NOT NULL, 
    surname char(30) NOT NULL,
    fathername char(20),
    post_id INTEGER,
    address char(100) NOT NULL,
    phone char(15) NOT NULL,
    section_id INTEGER,
    FOREIGN KEY(post_id) REFERENCES posts(id) ON UPDATE SET NULL ON DELETE SET NULL,
    FOREIGN KEY(section_id) REFERENCES section(id) ON UPDATE SET NULL ON DELETE SET NULL
);

ALTER TABLE section
ADD FOREIGN KEY(manager_id) REFERENCES worker(id) ON UPDATE SET NULL ON DELETE SET NULL;

CREATE TABLE product(
  
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    name char(100) NOT NULL,
    description TEXT,
    price FLOAT NOT NULL
);

CREATE TABLE storage_product(
    
    product_id INTEGER NOT NULL,
    amount FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY(product_id) REFERENCES product(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE provider(
  
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    name char(50) NOT NULL,
    address char(100) NOT NULL,
    phone char(15) NOT NULL
);

CREATE TABLE provider_product(
    
  	provider_id INTEGER NOT NULL,
    product_id INTEGER NOT NULL,
	date DATE NOT NULL,
	amount FLOAT NOT NULL,
	price FLOAT NOT NULL,
    FOREIGN KEY(provider_id) REFERENCES provider(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY(product_id) REFERENCES product(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE deals(
  
    product_id INTEGER NOT NULL,
    date DATE NOT NULL,
    amount FLOAT NOT NULL,
	price FLOAT NOT NULL,
    FOREIGN KEY(product_id) REFERENCES product(id) ON UPDATE CASCADE ON DELETE NO ACTION
);