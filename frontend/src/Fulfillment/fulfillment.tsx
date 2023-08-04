import React from 'react';
import { Link } from 'react-router-dom';
import data from './fulfillmentData';

function Fulfillment() {
    return (
        <div className = "content content-margined">
            <div className = "fulfillment-header">
                <h3>Fulfillment</h3>
            </div>
            <div className = "Fulfillment-list">
                <table className = "table">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>DATE</th>
                            <th>PRODUCT</th>
                            <th>TOTAL</th>
                            <th>USER</th>
                            <th>PAID</th>
                            <th>PAID AT</th>
                            <th>SHIPPED</th>
                            <th>DELIVERED</th>
                            <th>DELIVERED AT</th>
                            <th>ACTIONS</th>
                        </tr>
                    </thead>
                    <tbody>
                        {data.orders.map(order => (<tr key = {order._id}>
                            <td className = {order.isShipped.toString()}>{order._id}</td>
                            <td className = {order.isShipped.toString()}>{order.createdAt}</td>
                            <td className = {order.isShipped.toString()}>{order.products}</td>
                            <td className = {order.isShipped.toString()}>{order.totalPrice}</td>
                            <td className = {order.isShipped.toString()}>{order.user.name}</td>
                            <td className = {order.isShipped.toString()}>{order.isPaid.toString()}</td>
                            <td className = {order.isShipped.toString()}>{order.paidAt}</td>
                            <td className = {order.isShipped.toString()}>{order.isShipped.toString()}</td>
                            <td className = {order.isShipped.toString()}>{order.isDelivered.toString()}</td>
                            <td className = {order.isShipped.toString()}>{order.deliveredDate}</td>
                            <td>
                                <Link to = {"/fulfillment/" + order._id} className = "button secondary">Details</Link>
                            </td>
                        </tr>))}
                    </tbody>
                </table>
            </div>
        </div>);
};

export default Fulfillment;