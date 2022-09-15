package com.evertonogura.genericapi.model;

import java.io.Serializable;
import java.util.Objects;

public class ErrorModel implements Serializable {
	
	private static final long serialVersionUID = -8099995582862048054L;
	
	private String detail;
	
	public ErrorModel() {}

	public ErrorModel(String detail) {
		super();
		this.detail = detail;
	}

	public String getDetail() {
		return detail;
	}

	public void setDetail(String detail) {
		this.detail = detail;
	}

	@Override
	public int hashCode() {
		return Objects.hash(detail);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		ErrorModel other = (ErrorModel) obj;
		return Objects.equals(detail, other.detail);
	}

	@Override
	public String toString() {
		return "Error [detail=" + detail + "]";
	}
	
}
