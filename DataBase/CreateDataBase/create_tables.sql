
--CREATE DATABASE shop1;

CREATE TABLE address
(
  id serial NOT NULL,
  country character varying(100) NOT NULL,
  region character varying(100) NOT NULL,
  city character varying(100) NOT NULL,
  street character varying(100) NOT NULL,
  house character varying(10)NOT NULL,
  flat character varying(10)NOT NULL,
  CONSTRAINT pk_address_id PRIMARY KEY (id)
);

CREATE TABLE manager
(
  id serial NOT NULL,
  fio name,
  birthday date,
  phone character varying(25),
  CONSTRAINT pk_manager_id PRIMARY KEY (id)
);

CREATE TABLE client
(
  id serial NOT NULL,
  fio name NOT NULL,
  birthday date,
  phone character varying(25) NOT NULL,
  manager_id bigint,
  address_id bigint NOT NULL,
  CONSTRAINT pk_client_id PRIMARY KEY (id),
  
  CONSTRAINT fk_address_id FOREIGN KEY (address_id) REFERENCES address (id) MATCH SIMPLE
      ON UPDATE CASCADE
      ON DELETE RESTRICT,
      
  CONSTRAINT fk_manager_id FOREIGN KEY (manager_id)REFERENCES manager (id) MATCH SIMPLE
      ON UPDATE CASCADE 
      ON DELETE NO ACTION
);

CREATE TABLE order
(
  id serial NOT NULL,
  start date NOT NULL,
  finish date NOT NULL,
  manager_id bigint NOT NULL,
  client_id bigint NOT NULL,
  CONSTRAINT pk_order_id PRIMARY KEY (id),
  
  CONSTRAINT fk_client_id FOREIGN KEY (client_id) REFERENCES client (id) MATCH SIMPLE
      ON UPDATE CASCADE 
      ON DELETE CASCADE,
      
  CONSTRAINT fk_manager_id FOREIGN KEY (manager_id) REFERENCES manager (id) MATCH SIMPLE
      ON UPDATE CASCADE 
      ON DELETE NO ACTION
);

CREATE TABLE type
(
  id serial NOT NULL,
  name character varying(100) NOT NULL,
  CONSTRAINT pk_type_id PRIMARY KEY (id)
);

CREATE TABLE product
(
  id serial NOT NULL,
  name character varying(1000) NOT NULL,
  price numeric NOT NULL,
  colour character varying(100),
  type_id bigint,
  amount integer,
  material character varying(100),
  print character varying,
  description text,
  characteristics json,
  
  CONSTRAINT pk_product_id PRIMARY KEY (id),
  
  CONSTRAINT fk_type_id FOREIGN KEY (type_id) REFERENCES type (id) MATCH SIMPLE
      ON UPDATE CASCADE 
      ON DELETE RESTRICT
);

CREATE TABLE item
(
  id serial NOT NULL,
  order_id bigint NOT NULL,
  product_id bigint NOT NULL,
  amount integer NOT NULL,
  
  CONSTRAINT pk_item_id PRIMARY KEY (id),
  
  CONSTRAINT fk_order_id FOREIGN KEY (order_id) REFERENCES order (id) MATCH SIMPLE
      ON UPDATE CASCADE
      ON DELETE CASCADE,
      
  CONSTRAINT fk_product_id FOREIGN KEY (product_id) REFERENCES product (id) MATCH SIMPLE
      ON UPDATE NO ACTION
      ON DELETE SET NULL
);