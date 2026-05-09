CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL
);

CREATE TABLE student (
    student_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT UNIQUE,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    album_number INT NOT NULL UNIQUE,
    gender VARCHAR(50),
    group_name VARCHAR(255),
    CONSTRAINT fk_student_user FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE teacher (
    teacher_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT UNIQUE,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    gender VARCHAR(50),
    CONSTRAINT fk_teacher_user FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE admin (
    admin_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT UNIQUE,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    CONSTRAINT fk_admin_user FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE course (
    course_id INT IDENTITY(1,1) PRIMARY KEY,
    course_name VARCHAR(255) NOT NULL,
    teacher_id INT,
    result VARCHAR(255),
    CONSTRAINT fk_course_teacher FOREIGN KEY (teacher_id) REFERENCES teacher(teacher_id)
);


CREATE TABLE grades (
    grade_id INT IDENTITY(1,1) PRIMARY KEY,
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    grade_value VARCHAR(50) NOT NULL,
    grade_date DATE DEFAULT GETDATE(),
    CONSTRAINT fk_grade_student FOREIGN KEY (student_id) REFERENCES student(student_id),
    CONSTRAINT fk_grade_course FOREIGN KEY (course_id) REFERENCES course(course_id)
);
