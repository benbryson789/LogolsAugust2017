import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Student } from './../../entities/student';
import { Subject } from './../../entities/subject';
import { Answer } from './../../entities/answer';
import { Assessment } from './../../entities/assessment';
import { Level } from './../../entities/level';
import { Question } from './../../entities/question';
import { StudentAssessment } from './../../entities/studentassessment';
import { AnswerService } from './../../services/answer.service';
import { AssessmentService } from './../../services/assessment.service';
import { LevelService } from './../../services/level.service';
import { QuestionService } from './../../services/question.service';
import { StudentService } from './../../services/student.service';
import { StudentAssessmentService } from './../../services/studentassessment.service';
import { SubjectService } from './../../services/subject.service';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public students: Student[];
    public subjects: Subject[];
    public answers: Answer[];
    public assessments: Assessment[];
    public levels: Level[];
    public questions: Question[];
    public studentAssessments: StudentAssessment[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        let studentService = new StudentService(http, baseUrl);
        studentService.getAll().subscribe(result => {
            this.students = result.json() as Student[];
        }, error => console.error(error));

        let subjectService = new SubjectService(http, baseUrl);
        subjectService.getAll().subscribe(result => {
            this.subjects = result.json() as Subject[];
        }, error => console.error(error));

        let answerService = new AnswerService(http, baseUrl);
        answerService.getAll().subscribe(result => {
            this.answers = result.json() as Answer[];
        }, error => console.error(error));

        let assessmentService = new AssessmentService(http, baseUrl);
        assessmentService.getAll().subscribe(result => {
            this.assessments = result.json() as Assessment[];
        }, error => console.error(error));

        let levelService = new LevelService(http, baseUrl);
        levelService.getAll().subscribe(result => {
            this.levels = result.json() as Level[];
        }, error => console.error(error));

        let questionService = new QuestionService(http, baseUrl);
        questionService.getAll().subscribe(result => {
            this.questions = result.json() as Question[];
        }, error => console.error(error));

        let studentAssessmentService = new StudentAssessmentService(http, baseUrl);
        studentAssessmentService.getAll().subscribe(result => {
            this.studentAssessments = result.json() as StudentAssessment[];
        }, error => console.error(error));
    }
}