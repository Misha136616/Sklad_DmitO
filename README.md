# Warehouse for DmitOvochi
check coloborators
# BD FOR FUTURE LOOL
-- Таблица продукции
CREATE TABLE product (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255) NOT NULL,
    variety NVARCHAR(255),
    weight_per_unit DECIMAL(10,2),
    category NVARCHAR(50) CHECK (category IN ('стандарт', 'нестандарт', 'корм', 'отход')),
    source NVARCHAR(255) CHECK (source IN ('ФУДАГРОТРЕЙД', 'сторонний поставщик')),
    created_at DATETIME DEFAULT GETDATE(),
    washed_at DATETIME NULL,
    packaged_at DATETIME NULL,
    sold_at DATETIME NULL
);

-- Таблица клиентов
CREATE TABLE clients (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255) NOT NULL,
    contact_info NVARCHAR(MAX),
    address NVARCHAR(MAX),
    client_type NVARCHAR(50) CHECK (client_type IN ('магазин', 'оптовик', 'переработчик', 'трейдер'))
);

-- Таблица заказов
CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    client_id INT FOREIGN KEY REFERENCES clients(id) ON DELETE SET NULL,
    order_type NVARCHAR(50) CHECK (order_type IN ('продажа', 'услуга')),
    status NVARCHAR(50) CHECK (status IN ('новый', 'в процессе', 'выполнен')),
    created_at DATETIME DEFAULT GETDATE(),
    processed_at DATETIME NULL,
    shipped_at DATETIME NULL,
    quantity DECIMAL(10,2) NOT NULL,
    packaging_type NVARCHAR(50) CHECK (packaging_type IN ('биг-бэг', 'сетка', 'домики')),
    packaging_weight DECIMAL(10,2),
    gross_weight DECIMAL(10,2),
    net_weight DECIMAL(10,2),
    price_per_unit DECIMAL(10,2),
    total_price DECIMAL(10,2)
);

-- Таблица сотрудников
CREATE TABLE employees (
    id INT IDENTITY(1,1) PRIMARY KEY,
    full_name NVARCHAR(255) NOT NULL,
    position NVARCHAR(255),
    salary_type NVARCHAR(50),
    hours_worked DECIMAL(10,2),
    salary DECIMAL(10,2),
    login_credentials NVARCHAR(MAX)
);

-- Таблица расходных материалов
CREATE TABLE supplies (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255) NOT NULL,
    unit NVARCHAR(50),
    quantity_available DECIMAL(10,2),
    quantity_used DECIMAL(10,2),
    last_updated_at DATETIME DEFAULT GETDATE()
);