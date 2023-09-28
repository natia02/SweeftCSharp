CREATE TABLE Teacher (
    teacher_id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    subject VARCHAR(255) NOT NULL
);

CREATE TABLE Pupil (
    pupil_id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    class INT NOT NULL
);

CREATE TABLE TeacherPupil (
    teacher_id INT,
    pupil_id INT,
    PRIMARY KEY (teacher_id, pupil_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(id),
    FOREIGN KEY (pupil_id) REFERENCES Pupil(pupil_id)
);

SELECT DISTINCT t.teacher_id, t.FirstName, t.LastName
FROM Teacher t
INNER JOIN TeacherPupil tpr ON t.teacher_id = tpr.teacher_id
INNER JOIN Pupil p ON tpr.pupil_id = p.pupil_id
WHERE p.FirstName = 'George';
