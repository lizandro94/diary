import React from 'react';
import MainLayout from './Mainlayout';

const IndexLayout = ({ children }) => {
    return (
        <React.Fragment>
            <MainLayout>{children}</MainLayout>
        </React.Fragment>
    );
};

export default IndexLayout;