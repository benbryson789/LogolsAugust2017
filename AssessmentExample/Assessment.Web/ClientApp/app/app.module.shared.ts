import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { AdminComponent } from './components/admin/admin.component';
import { AssessmentComponent } from './components/assessment/assessment.component';
import { QuestionComponent } from './components/question/question.component';
import { AssessmentAdminComponent } from './components/assessmentAdmin/assessmentAdmin.component';
import { QuestionAdminComponent } from './components/questionAdmin/questionAdmin.component';
import { LevelAdminComponent } from './components/levelAdmin/levelAdmin.component';
import { SubjectAdminComponent } from './components/subjectAdmin/subjectAdmin.component';
import { AnswerAdminComponent } from './components/answerAdmin/answerAdmin.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        AdminComponent,
        FetchDataComponent,
        HomeComponent,
        AssessmentComponent,
        QuestionComponent,
        AssessmentAdminComponent,
        QuestionAdminComponent,
        LevelAdminComponent,
        SubjectAdminComponent,
        AnswerAdminComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'admin', component: AdminComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'assessment/:id', component: AssessmentComponent },
            { path: 'assessmentAdmin', component: AssessmentAdminComponent },
            { path: 'questionAdmin/:assessmentID', component: QuestionAdminComponent },
            { path: 'answerAdmin/:questionID', component: AnswerAdminComponent },
            { path: 'levelAdmin', component: LevelAdminComponent },
            { path: 'subjectAdmin', component: SubjectAdminComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
