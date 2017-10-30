import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';

interface FetchDataExampleState {
    sales: Sale[];
    loading: boolean;
}

export class FetchData extends React.Component<RouteComponentProps<{}>, FetchDataExampleState> {
    constructor() {
        super();
        this.state = { sales: [], loading: true };

        fetch('api/Sale')
            .then(response => response.json() as Promise<Sale[]>)
            .then(data => {
                this.setState({ sales: data, loading: false });
            });
    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderSalesTable(this.state.sales);

        return <div>
            <h1>Sales</h1>
            <p>This component demonstrates fetching data from the server.</p>
            { contents }
        </div>;
    }

    private static renderSalesTable(sales: Sale[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Sum</th>
                    <th>Time</th>
                    <th>Additional info</th>
                </tr>
            </thead>
            <tbody>
            {sales.map(sale =>
                    <tr key={sale.id }>
                        <td>{sale.name}</td>
                        <td>{sale.sum}</td>
                        <td>{sale.time}</td>
                        <td>{sale.additionalInformation}</td>
                </tr>
            )}
            </tbody>
        </table>;
    }
}

interface Sale {
    id: number;
    name: string;
    time: Date;
    additionalInformation: string;
    sum: number;
    items: Item[];
}
interface Item {
    name: string;
    cost: number;
    id: number;
}