import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';

export const routes = <Layout>
    <Route path='/fetch' component={ FetchData } />
    <Route path='/counter' component={ Counter } />
</Layout>;
