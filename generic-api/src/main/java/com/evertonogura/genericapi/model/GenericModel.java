package com.evertonogura.genericapi.model;

import java.io.Serializable;
import java.util.Date;
import java.util.List;
import java.util.Objects;

import com.fasterxml.jackson.annotation.JsonIgnore;

public class GenericModel implements Serializable {

	private static final long serialVersionUID = 6430583865568414423L;
	
	private Long id;
	
	private String name;
	
	private Boolean active;
	
	private Date date;
	
	private List<GenericChildModel> items;
	
	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Boolean getActive() {
		return active;
	}

	public void setActive(Boolean active) {
		this.active = active;
	}

	public Date getDate() {
		return date;
	}

	public void setDate(Date date) {
		this.date = date;
	}

	public List<GenericChildModel> getItems() {
		return items;
	}

	public void setItems(List<GenericChildModel> items) {
		this.items = items;
	}

	public GenericModel() {}

	public GenericModel(Long id, String name, Boolean active, Date date, List<GenericChildModel> items) {
		super();
		this.id = id;
		this.name = name;
		this.active = active;
		this.date = date;
		this.items = items;
	}

	@Override
	public int hashCode() {
		return Objects.hash(active, date, id, items, name);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		GenericModel other = (GenericModel) obj;
		return Objects.equals(active, other.active) && Objects.equals(date, other.date) && Objects.equals(id, other.id)
				&& Objects.equals(items, other.items) && Objects.equals(name, other.name);
	}

	@Override
	public String toString() {
		return "GenericModel [id=" + id + ", name=" + name + ", active=" + active + ", date=" + date + ", items="
				+ items + "]";
	}
	
}
