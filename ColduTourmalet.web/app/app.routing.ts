import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home.component';
import { Page1Component } from './page1.component';
import { Page2Component } from './page2.component';
import { JournalEntryDetailComponent} from './journalEntry.component';

const appRoutes: Routes = [
    {
        path: '',
        component: HomeComponent
    },
    {
        path: 'page1',
        component: Page1Component
    },
    {
        path: 'page2',
        component: Page2Component
    },
    {
        path: 'detail/:id',
        component: JournalEntryDetailComponent
    }
];

export const routing = RouterModule.forRoot(appRoutes);

