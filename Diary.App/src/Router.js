import React from 'react';
import { BrowserRouter, Switch, Route } from "react-router-dom";
import IndexLayout from './layouts/IndexLayout';

const Router = () => {
    return (
        <BrowserRouter>
            <IndexLayout>
                <Switch>
                    
                </Switch>
            </IndexLayout>
        </BrowserRouter>
    );
};

export default Router;